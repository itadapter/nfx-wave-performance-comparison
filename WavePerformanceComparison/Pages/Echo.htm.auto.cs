//WARNING: This code was auto generated by template compiler, do not modify by hand!
//Generated on 14.06.2015 9:43:39 by NFX.Templatization.TextCSTemplateCompiler at TRIAL

using System; 
using System.Text; 
using System.Linq; 
using System.Collections.Generic; 

namespace WavePerformanceComparison.Pages 
{

 ///<summary>
 /// Echo test page
 ///</summary>
 public  class Echo : WavePerformanceComparison.Pages.Master
 {

     protected override void DoRender()
     {
       base.DoRender();
        Target.Write( Echo._25_S_LITERAL_0 );

     }
    protected override void  renderBody()
    {
        Target.Write( Echo._25_S_LITERAL_1 );

    }


     #region Literal blocks content
        private const string _25_S_LITERAL_0 = @"

    
"; 
        private const string _25_S_LITERAL_1 = @"
    <h2>Enter a string to run the echo test:</h2>
    <form id=""frm"" action=""/mvc/test/echo"" method=""post"">
        Any string: <input type=""text"" name=""data""> 
        &nbsp;
        <input type=""submit"" value=""Submit"">
    </form>"; 
     #endregion

 }//class
}//namespace