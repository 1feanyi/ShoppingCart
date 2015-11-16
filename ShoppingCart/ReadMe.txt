
Shopping Cart Application (No Auth)

=============================================================================

Core: ASP.NET MVC (C#), Bootstrap, Knockout.js

=============================================================================

Installed Packages:
-------------------
Id                             Version              Description/Release Notes                                                                                                                                                 
--                             -------              -------------------------                                                                                                                                                 
Antlr                          3.5.0.2              ANother Tool for Language Recognition, is a language tool that provides a framework for constructing recognizers, interpreters, compilers, and translators from grammat...
AutoMapper                     4.1.1                A convention-based object-object mapper. AutoMapper uses a fluent configuration API to define an object-object mapping strategy. AutoMapper uses a convention-based mat...
bootstrap                      3.3.5                The most popular front-end framework for developing responsive, mobile first projects on the web.                                                                         
EntityFramework                6.1.3                Entity Framework is Microsoft's recommended data access technology for new applications.                                                                                  
jQuery                         2.1.4                jQuery is a new kind of JavaScript Library....                                                                                                                            
jQuery.UI.Combined             1.11.4               jQuery UI is an open source library of interface components — interactions, full-featured widgets, and animation effects — based on the stellar jQuery javascript libra...
jQuery.Validation              1.14.0               This jQuery plugin makes simple clientside form validation trivial, while offering lots of option for customization. That makes a good choice if you’re building someth...
knockoutjs                     3.3.0                A JavaScript MVVM library to help you create rich, dynamic user interfaces with clean maintainable code                                                                   
Microsoft.AspNet.Mvc           5.2.3                This package contains the runtime assemblies for ASP.NET MVC. ASP.NET MVC gives you a powerful, patterns-based way to build dynamic websites that enables a clean separ...
Microsoft.AspNet.Razor         3.2.3                This package contains the runtime assemblies for ASP.NET Web Pages. ASP.NET Web Pages and the new Razor syntax provide a fast, terse, clean and lightweight way to comb...
Microsoft.AspNet.Web.Optimi... 1.1.3                ASP.NET Optimization introduces a way to bundle and optimize CSS and JavaScript files.                                                                                    
Microsoft.AspNet.WebApi        5.2.3                This package contains everything you need to host ASP.NET Web API on IIS. ASP.NET Web API is a framework that makes it easy to build HTTP services that reach a broad r...
Microsoft.AspNet.WebApi.Client 5.2.3                This package adds support for formatting and content negotiation to System.Net.Http. It includes support for JSON, XML, and form URL encoded data.                        
Microsoft.AspNet.WebApi.Core   5.2.3                This package contains the core runtime assemblies for ASP.NET Web API. This package is used by hosts of the ASP.NET Web API runtime. To host a Web API in IIS use the M...
Microsoft.AspNet.WebApi.Web... 5.2.3                This package contains everything you need to host ASP.NET Web API on IIS. ASP.NET Web API is a framework that makes it easy to build HTTP services that reach a broad r...
Microsoft.AspNet.WebPages      3.2.3                This package contains core runtime assemblies shared between ASP.NET MVC and ASP.NET Web Pages.                                                                           
Microsoft.Bcl                  1.1.9                This packages enables projects targeting down-level platforms to use some of the types added in later versions including:...                                              
Microsoft.Bcl.Build            1.0.14               This package provides build infrastructure components so that projects referencing specific Microsoft packages can successfully build....                                 
Microsoft.jQuery.Unobtrusiv... 3.2.3                jQuery plugin that unobtrusively sets up jQuery.Validation.                                                                                                               
Microsoft.Net.Http             2.2.22               This package includes HttpClient for sending requests over HTTP, as well as HttpRequestMessage and HttpResponseMessage for processing HTTP messages....                   
Microsoft.Web.Infrastructure   1.0.0.0              This package contains the Microsoft.Web.Infrastructure assembly that lets you dynamically register HTTP modules at run time.                                              
Modernizr                      2.8.3                Modernizr adds classes to the <html> element which allow you to target specific browser functionality in your stylesheet. You don't actually need to write any Javascri...
Newtonsoft.Json                7.0.1                Json.NET is a popular high-performance JSON framework for .NET                                                                                                            
Respond                        1.4.2                The goal of this script is to provide a fast and lightweight (3kb minified / 1kb gzipped) script to enable responsive web designs in browsers that don't support CSS3 M...
WebGrease                      1.6.0                Web Grease is a suite of tools for optimizing javascript, css files and images.

=============================================================================

Features:
---------
Home page: The home page (all pages actually) will contain a list of categories that will help filter the genre of books. This will be displayed on the left-hand side. The righthand side will be used to display several featured books. Clicking a book will direct the user to the book details page.

Books by category: If a user clicks a category on the left-hand side, a list of books in that category will be displayed (similar to how featured books are displayed). Clicking a book will direct the user to the book details page.

Book details: The book details page is where users will go when they select a book. This page will display some basic information about the book and the all-important “Add to Cart” feature.

Cart details: Once an item is added to the cart, the cart details page will display all items currently in the user’s cart. This page will allow the user to edit the quantity or remove the item from the cart.

=============================================================================

Models:
-------
Author
Book
Category
Cart
CartItem