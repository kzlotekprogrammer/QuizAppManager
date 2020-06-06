using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using NLog;
using QuizAppManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace QuizAppManager
{
    class FirebaseHelper
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private static IFirebaseClient client;
        private static IFirebaseConfig config;

        static FirebaseHelper() 
        {
            config = new FirebaseConfig
            {
                AuthSecret = "Ldil6CYIzpjq5iBSzqnmcNI1oUQhKts3CP78w69Y",
                BasePath = "https://quizapp-e0d1e.firebaseio.com/"
            };

            client = new FirebaseClient(config);

            if (client != null)
            {
                logger.Info("Connection established");
            }
            else
            {
                logger.Error("Connection establishment failed");
            }
        }

        public static List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            FirebaseResponse response = client.Get("Categories");
            if(response.Exception != null)
            {
                logger.Error(response.Exception.Message);
                return null;
            }

            Dictionary<string, Category>  deserializedResponse = JsonConvert.DeserializeObject<Dictionary<string, Category>>(response.Body);
            if(deserializedResponse != null)
            {
                foreach (string key in deserializedResponse.Keys)
                {
                    Category category = deserializedResponse[key];
                    category.Id = key;
                    categories.Add(category);
                }
            }

            logger.Info(String.Format("Retrieved {0} categories", categories.Count));
            return categories;
        }

        public static bool EditCategory(Category category)
        {
            FirebaseResponse response = client.Update("Categories/" + category.Id, category);
            if (response.Exception != null)
            {
                logger.Error(response.Exception.Message);
                return false;
            }
            else
            {
                logger.Info(String.Format("Category edited - response.Body: {0}", response.Body));
                return true;
            }
        }

        public static bool DeleteCategory(Category category)
        {
            DeleteResponse response = client.Delete("Categories/" + category.Id);
            if (response.Exception != null)
            {
                logger.Error(response.Exception.Message);
                return false;
            }
            else
            {
                logger.Info(String.Format("Category deleted - response.Body: {0}", response.Body));
                return true;
            }
        }

        public static bool InsertCategory(Category category)
        {
            PushResponse response = client.Push("Categories", category);
            if (response.Exception != null)
            {
                logger.Error(response.Exception.Message);
                return false;
            }
            else
            {
                logger.Info(String.Format("Category added - response.Body: {0}", response.Body));
                return true;
            }
        }
    }
}
