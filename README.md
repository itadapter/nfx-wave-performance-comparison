# nfx-wave-performance-comparison
This application covers a set of simple performance tests for NFX.WAVE framework:
 * A simple string echo
 * A JSON packed echo responce
 * A dynamic JSON representation of data object
 * A dynamic page rendered by templete engine for data object
 * A random payload of given length dynamically generated via MVC pipeline
 * A random payload dynamically generated through template engine without MVC pipeline

URLs for tests:

* &lt;site root&gt;/mvc/test/RandomPerson     - returns a JSON representation of randomly generated Person object
* &lt;site roo&gt;/mvc/test/RandomPayload?length=&lt;integer number&gt; - returns a random string of specified length
* &lt;site root&gt;/mvc/test/Echo?data=&lt;any string&gt; - returns a simple string echo of string that was sent as the parameter
* &lt;site root&gt;/pages/RandomPerson   - returns a page with CSS styles and formatting with a representation of randomly generated Person object
* &lt;site root&gt;/pages/RandomPersonSimple   - returns a very minimalistic page with a representation of randomly generated Person object
* &lt;site root&gt;/pages/RandomPayload?length=&lt;integer number&gt; - returns a random string of specified length through template engine without invoking MVC

There is a <a href="https://github.com/nik-z/asp-net-performance-comparison">counterpart ASP.NET application</a> to make performance comparison possible between ASP.NET and NFX.Wave.
