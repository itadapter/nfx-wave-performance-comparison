//WARNING: This code was auto generated by template compiler, do not modify by hand!
//Generated on 14.06.2015 9:43:39 by NFX.Templatization.TextCSTemplateCompiler at TRIAL

using System; 
using System.Text; 
using System.Linq; 
using System.Collections.Generic; 

namespace WavePerformanceComparison.Pages 
{

 ///<summary>
 /// Template engine test page
 ///</summary>
 public  class RandomPayload1000 : NFX.Wave.Templatization.WaveTemplate
 {

     
     protected override void DoRender()
     { 
       base.DoRender();
        Target.Write( RandomPayload1000._32_S_LITERAL_0 );
        Target.Write( RandomPayload1000._32_S_LITERAL_1 );
        Target.Write(Target.Encode( WavePerformanceComparison.Data.RandomPayload.generate(1000) ));

     }


     #region Literal blocks content
        private const string _32_S_LITERAL_0 = @"

"; 
        private const string _32_S_LITERAL_1 = @"
"; 
     #endregion

 }//class
}//namespace
