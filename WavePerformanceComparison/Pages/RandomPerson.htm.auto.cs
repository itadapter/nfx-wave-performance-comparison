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
 public  class RandomPerson : WavePerformanceComparison.Pages.Master
 {

    public override string Title { get {return "NFX.Wave template engine test"; } }


     protected override void DoRender()
     {
       base.DoRender();
        Target.Write( RandomPerson._24_S_LITERAL_0 );

     }
    protected override void  renderHeader()
    {
        Target.Write( RandomPerson._24_S_LITERAL_1 );
        Target.Write(Target.Encode( DateTime.Now ));
        Target.Write( RandomPerson._24_S_LITERAL_2 );

    }
    protected override void  renderBody()
    {
        Target.Write( RandomPerson._24_S_LITERAL_3 );
      WavePerformanceComparison.Data.Person p = WavePerformanceComparison.Data.Persons.ARandomOne();
        Target.Write( RandomPerson._24_S_LITERAL_4 );
        Target.Write(Target.Encode( p.FirstName ));
        Target.Write( RandomPerson._24_S_LITERAL_5 );
        Target.Write(Target.Encode( p.LastName ));
        Target.Write( RandomPerson._24_S_LITERAL_6 );
        Target.Write(Target.Encode( p.Gender ));
        Target.Write( RandomPerson._24_S_LITERAL_7 );
        Target.Write(Target.Encode( p.MaritalStatus ));
        Target.Write( RandomPerson._24_S_LITERAL_8 );
        Target.Write(Target.Encode( p.Age ));
        Target.Write( RandomPerson._24_S_LITERAL_9 );
        Target.Write(Target.Encode( p.Weight ));
        Target.Write( RandomPerson._24_S_LITERAL_10 );
        Target.Write(Target.Encode( p.Height ));
        Target.Write( RandomPerson._24_S_LITERAL_11 );
        Target.Write(Target.Encode( p.Education ));
        Target.Write( RandomPerson._24_S_LITERAL_12 );
        Target.Write(Target.Encode( p.Degree ));
        Target.Write( RandomPerson._24_S_LITERAL_13 );
        Target.Write(Target.Encode( p.Occupation ));
        Target.Write( RandomPerson._24_S_LITERAL_14 );

    }
    protected override void  renderFooter()
    {
        Target.Write( RandomPerson._24_S_LITERAL_15 );
      base.renderFooter();

    }


     #region Literal blocks content
        private const string _24_S_LITERAL_0 = @"

"; 
        private const string _24_S_LITERAL_1 = @"
        <h2>Current time is "; 
        private const string _24_S_LITERAL_2 = @"</h2><br />
        <h1>And the winner of ""The Random Person of The Moment"" nomination is...</h1>*


"; 
        private const string _24_S_LITERAL_3 = @"
    "; 
        private const string _24_S_LITERAL_4 = @"

    <div id=""divContent"">
        <table>
            <tr><td>First name: </td><td>"; 
        private const string _24_S_LITERAL_5 = @"</td></tr>
            <tr><td>Last name: </td><td>"; 
        private const string _24_S_LITERAL_6 = @"</td></tr>
            <tr><td></td><td></td></tr>
            <tr><td>Gender: </td><td>"; 
        private const string _24_S_LITERAL_7 = @"</td></tr>
            <tr><td>Marital status: </td><td>"; 
        private const string _24_S_LITERAL_8 = @"</td></tr>
            <tr><td></td><td></td></tr>
            <tr><td>Age: </td><td>"; 
        private const string _24_S_LITERAL_9 = @"</td></tr>
            <tr><td>Weight (kg): </td><td>"; 
        private const string _24_S_LITERAL_10 = @"</td></tr>
            <tr><td>Height (cm): </td><td>"; 
        private const string _24_S_LITERAL_11 = @"</td></tr>
            <tr><td></td><td></td></tr>
            <tr><td>Education: </td><td>"; 
        private const string _24_S_LITERAL_12 = @"</td></tr>
            <tr><td>Degree: </td><td>"; 
        private const string _24_S_LITERAL_13 = @"</td></tr>
            <tr><td>Occupation: </td><td>"; 
        private const string _24_S_LITERAL_14 = @"</td></tr>
        </table>
     </div>

"; 
        private const string _24_S_LITERAL_15 = @"
        * This is a work of fiction. Any resemblance to actual events or locales or persons is entirely coincidental. <br /><br />
        "; 
     #endregion

 }//class
}//namespace