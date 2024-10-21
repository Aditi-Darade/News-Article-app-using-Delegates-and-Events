In this assignment, you will create a C# console application that demonstrates the use of delegates and events. You will create a NewsArticle class that represents a news article, a NewsArticleCollection class that represents a collection of news articles, and a console application that uses the NewsArticleCollection class to filter news articles by category and notify subscribers when new articles are added to or removed from the collection.



Requirements
Create a NewsArticle class with the following properties:

Title (string): the title of the news article

Category (string): the category of the news article

Create a constructor that takes a title and a category and initializes the corresponding properties.

Create a NewsArticleCollection class with the following properties and methods:

articles (List<NewsArticle>): a list of news articles in the collection

AddArticle(NewsArticle article): adds a news article to the collection

RemoveArticle(NewsArticle article): removes a news article from the collection

FilterArticlesByCategory(string category): returns a list of news articles in the collection with the specified category

articleAddedHandler (delegate): a delegate that is invoked when a new article is added to the collection

articleRemovedHandler (delegate): a delegate that is invoked when an article is removed from the collection

articleFilteredHandler (delegate): a delegate that is invoked when articles are filtered by category

RegisterArticleAddedHandler(Action<object, NewsArticle> handler): registers an event handler for the article added event

RegisterArticleRemovedHandler(Action<object, NewsArticle> handler): registers an event handler for the article removed event

RegisterArticleFilteredHandler(string category, Action<object, string> handler): registers an event handler for the article filtered event

When a new article is added to the collection, the articleAddedHandler delegate should be invoked with the NewsArticleCollection object and the new NewsArticle object as parameters.

When an article is removed from the collection, the articleRemovedHandler delegate should be invoked with the NewsArticleCollection object and the removed NewsArticle object as parameters.

When articles are filtered by category, the articleFilteredHandler delegate should be invoked with the NewsArticleCollection object and the category as parameters.

Create a console application that demonstrates the use of the NewsArticleCollection class by doing the following:

Create a new NewsArticleCollection object

Register an event handler for the "Sports" category

Add some news articles to the collection

Filter the collection by the "Sports" category

Remove an article from the collection

Filter the collection by the "Sports" category again to demonstrate that the removal was successful

When a new article is added to or removed from the collection, the console application should write a message to the console indicating that the event was fired.

Implement the articleFilteredHandler delegate using a lambda expression.



Submission
Submit your source code as a single ".cs" file. Your source code should include:

The NewsArticle class

The NewsArticleCollection class

The console application that demonstrates the use of the NewsArticleCollection class



Sample Output:

Article added: New iPhone release (Technology)
Articles filtered by category 'Technology'
Article added: Record profits for Apple (Business)
Articles filtered by category 'Business'
Article added: New study shows benefits of exercise (Health)
Articles filtered by category 'Health'
Articles filtered by category 'Technology'
Article removed: Record profits for Apple (Business)
Articles filtered by category 'Business'
