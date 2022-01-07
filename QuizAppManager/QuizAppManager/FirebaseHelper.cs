using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using NLog;
using QuizAppManager.Models;
using System.Collections.Generic;

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

            logger.Info(string.Format("Retrieved {0} categories", categories.Count));
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
                logger.Info(string.Format("Category edited - response.Body: {0}", response.Body));
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
                logger.Info(string.Format("Category deleted - response.Body: {0}", response.Body));
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
                logger.Info(string.Format("Category added - response.Body: {0}", response.Body));
                return true;
            }
        }

        public static List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>();

            FirebaseResponse response = client.Get("Questions");
            if (response.Exception != null)
            {
                logger.Error(response.Exception.Message);
                return null;
            }

            Dictionary<string, Question> deserializedResponse = JsonConvert.DeserializeObject<Dictionary<string, Question>>(response.Body);
            if (deserializedResponse != null)
            {
                foreach (string key in deserializedResponse.Keys)
                {
                    Question question = deserializedResponse[key];
                    question.Id = key;
                    questions.Add(question);
                }
            }

            logger.Info(string.Format("Retrieved {0} categories", questions.Count));
            return questions;
        }

        public static bool EditQuestion(Question question)
        {
            FirebaseResponse response = client.Update("Questions/" + question.Id, question);
            if (response.Exception != null)
            {
                logger.Error(response.Exception.Message);
                return false;
            }
            else
            {
                logger.Info(string.Format("Question edited - response.Body: {0}", response.Body));
                return true;
            }
        }

        public static bool DeleteQuestion(Question question)
        {
            DeleteResponse response = client.Delete("Questions/" + question.Id);
            if (response.Exception != null)
            {
                logger.Error(response.Exception.Message);
                return false;
            }
            else
            {
                logger.Info(string.Format("Question deleted - response.Body: {0}", response.Body));
                return true;
            }
        }

        public static bool InsertQuestion(Question question)
        {
            PushResponse response = client.Push("Questions", question);
            if (response.Exception != null)
            {
                logger.Error(response.Exception.Message);
                return false;
            }
            else
            {
                logger.Info(string.Format("Question added - response.Body: {0}", response.Body));
                return true;
            }
        }
    }
}
