using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.NewsArticleCollection;

namespace Sec20_Assign41_NewsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            NewsArticle n1 = new NewsArticle("aaa", "boring");
            NewsArticle n2 = new NewsArticle("bbb", "fun");
            NewsArticle n3 = new NewsArticle("ccc", "fun");
            NewsArticle n4 = new NewsArticle("ddd", "fun");

            NewsArticleCollection newsArticleCollection = new NewsArticleCollection();

            articleAddedHandler articleAdded = new articleAddedHandler(newsArticleCollection.ArticleAdded);


            newsArticleCollection.AddArticle(n1);
            articleAdded.Invoke();
            System.Console.WriteLine(newsArticleCollection.articles[0].Title + ", " + newsArticleCollection.articles[0].Category);
 
            newsArticleCollection.AddArticle(n2);
            articleAdded.Invoke();
            System.Console.WriteLine(newsArticleCollection.articles[1].Title + ", " + newsArticleCollection.articles[1].Category);
            newsArticleCollection.RemoveArticle(n2);

            newsArticleCollection.AddArticle(n3);
            System.Console.WriteLine(newsArticleCollection.articles[1].Title + ", " + newsArticleCollection.articles[1].Category);

            newsArticleCollection.AddArticle(n4);
            System.Console.WriteLine(newsArticleCollection.articles[2].Title + ", " + newsArticleCollection.articles[2].Category);

            int listCount = newsArticleCollection.articles.Count;
            System.Console.WriteLine("List Count = " + listCount);
            System.Console.WriteLine("-------------------");

            newsArticleCollection.FilterArticlesByCategory("fun");
            System.Console.WriteLine("-------------------");

            //articleAddedHandler articleAdded = new articleAddedHandler(newsArticleCollection.ArticleAdded);
            articleAdded.Invoke();
      
            System.Console.ReadKey();
        }
    }
}
