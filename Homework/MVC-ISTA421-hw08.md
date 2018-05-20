## Ricardo Rosa

### ISTA421 Homework ProMVC 8

### ASP.NET

***In your ASP.Net MVC 5 book read Chapter 8 to answer the questions below***



#### 1. Describe the difference between a view and a partial view.
View:

MVC view contains the layout page.
Before any view is rendered, viewstart page is rendered.
View might have markup tags like body, html, head, title, meta etc.
View is not lightweight as compare to Partial View.
Partial View:

Partial does not contain the layout page.
It does not verify for a viewstart.cshtml. We cannot put common code for a partial view within the viewStart.cshtml.page.
In MVC Partial view is designed specially to render within the view and just because of that it does not consist any mark up.
We can pass a regular view to the RenderPartial method.

#### 2. Throughout the book you have seen examples of LINQ, in your own words describe what it is used for and how it works.

#### 3. Look at this piece of code and tell me what it does, and where I would find it written: a. routes.MapRoute(null, "{category}/Page{page}", new { controller = "Product", action = "List" },new { page = @"\d+" }); b. Which call maps to 3a?


#### 4. Give a brief explanation of the ASP.Net routing system.
Examine an incoming URL and figure out for which controller and action the request is intended.

Generate outgoing URLs. These are the URLs that appear in the HTML rendered from views
so that a specific action will be invoked when the user clicks the link (at which point, it has
become an incoming URL again).

#### 5. ASP.Net has a concept of child actions, can you describe it? How would you use it?
are perfect for creating items such as a reusable navigation control. A child action relies on the HTML helper method called Html.Action, which lets you include the output from an arbitrary action method in the current view.

#### 6. What is a _Layout.cshtml file? How do you use it, if at all?
It is a file that visual studio automatically adds

You use a child action 

#### 7. What is a ViewResult? A PartialViewResult? An ActionResult? When/how would you use them?
ViewResult - Renders a specifed view to the response stream.

PartialViewResult - Renders a specifed partial view to the response stream.

ActionResult is an abstract class that can have several subtypes.

#### 8. What is an Entity and how is it used in this project?
Entity is a Framework.

#### 9. When creating a form in ASP.Net what command can you use that will generate the traditional HTML element? What are action attributes and what kind of actions can a form perform?


#### 10. What is an ASP.Net session state? How is it being used in this project?
feature to store and retrieve Cart objects.

#### 11. Why would you create a separate Model object? What is it’s purpose?


#### 12. Describe some ways that Bootstrap was used in this chapter.

