//WARNING: This code was auto generated by template compiler, do not modify by hand!
//Generated on 14.06.2015 9:43:39 by NFX.Templatization.TextCSTemplateCompiler at TRIAL

using System; 
using System.Text; 
using System.Linq; 
using System.Collections.Generic; 
using NFX.Wave.Templatization; 

namespace WavePerformanceComparison.Pages 
{

 ///<summary>
 /// Master page for all pages on this site
 ///</summary>
 public abstract class Master : NFX.Wave.Templatization.WaveTemplate
 {

    public virtual string Title { get {return "NFX.WAVE Framework Performance Test"; } }

    public const string CONTENT_WIDTH = "90%";

    protected virtual void renderHeader() {defaultHeader();}
    protected abstract void renderBody();
    protected virtual void renderFooter() { defaultFooter(); }

     protected override void DoRender()
     {
       base.DoRender();
        Target.Write( Master._76_S_LITERAL_0 );
        Target.Write( Master._76_S_LITERAL_1 );
        Target.Write(Target.Encode( Title ));
        Target.Write( Master._76_S_LITERAL_2 );
        Target.Write(Target.Encode( CONTENT_WIDTH ));
        Target.Write( Master._76_S_LITERAL_3 );
        Target.Write(Target.Encode( CONTENT_WIDTH ));
        Target.Write( Master._76_S_LITERAL_4 );
        Target.Write(Target.Encode( CONTENT_WIDTH ));
        Target.Write( Master._76_S_LITERAL_5 );
      renderHeader();
        Target.Write( Master._76_S_LITERAL_6 );
      renderBody();
        Target.Write( Master._76_S_LITERAL_7 );
      renderFooter();
        Target.Write( Master._76_S_LITERAL_8 );

     }
    protected void defaultFooter()
    {
        Target.Write( Master._76_S_LITERAL_9 );
        Target.Write(Target.Encode( DateTime.Now ));
        Target.Write( Master._76_S_LITERAL_10 );

    }
    protected void defaultHeader()
    {
        Target.Write( Master._76_S_LITERAL_11 );

    }


     #region Literal blocks content
        private const string _76_S_LITERAL_0 = @"
"; 
        private const string _76_S_LITERAL_1 = @"
<!DOCTYPE html>
<html>
<head>
    <title>"; 
        private const string _76_S_LITERAL_2 = @"</title>
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />


    <style>
        body {
            font-family: Verdana, Sans-Serif;
            font-size: 9pt;
            width: auto;
            padding: 0px;
            border: none;
            background-color: white;
            margin: 0px;
            color: #7a7a7a;
            min-width: 500px;
        }

        h1 {
            font-size: 150%;
            color: White;
            text-shadow: Black 1px 1px 4px;
            display: inline;
            margin-left: 110px;
        }

        h2 {
            font-size: 120%;
            text-shadow: Silver 1px 1px 3px;
        }

        h3 {
            font-size: 100%;
            margin-bottom: -8px;
        }

        hr {
            border: none;
            width: 100%;
            background-color: #b8b8b8;
            height: 1px;
        }

        a {
            outline: none;
        }

        td {
            padding: 4px;
        }

        :link {
            font-size: 9pt;
            color: #3560a4;
            text-shadow: Silver -1px -1px 1px;
            text-decoration: none;
        }

            :link:hover {
                position: relative;
                left: 0px;
                top: -1px;
                text-shadow: Yellow 1px 1px 16px;
                color: #3560a4;
            }

        :visited {
            font-size: 9pt;
            text-decoration: none;
            color: #9a2497;
        }

        #divTopPanel {
            background-color: #f8433c;
            height: auto;
        }

        #divHeader {
            width: "; 
        private const string _76_S_LITERAL_3 = @";
            height: auto;
            background-color: #fba9a6;
            margin-left: auto;
            margin-right: auto;
            padding: 8pt;
        }

        #divContentPanel {
            background-color: #f0f0f0;
            height: auto;
        }

        #divContent {
            width: "; 
        private const string _76_S_LITERAL_4 = @";
            height: auto;
            background-color: #f8f6e4;
            margin-left: auto;
            margin-right: auto;
            padding: 8pt;
        }

        #divBottomPanel {
            background-color: #f8433c;
            height: auto;
        }

        #divBottomContent {
            width: "; 
        private const string _76_S_LITERAL_5 = @";
            height: auto;
            background-color: #fba9a6;
            margin-left: auto;
            margin-right: auto;
            padding: 8pt;
        }

        .orangeStripe {
            width: 100%;
            height: 4px;
            background-color: #f3a832;
        }

        .tail {
            text-align: center;
            width: 100%;
        }
    </style>

</head>
<body>
    <div id=""divTopPanel"">
        <div id=""divHeader"">"; 
        private const string _76_S_LITERAL_6 = @"</div>
    </div>

    <div id=""divContentPanel"">
        <div id=""divContent"">"; 
        private const string _76_S_LITERAL_7 = @"</div>
    </div>

    <div id=""divBottomPanel"">
        <div id=""divBottomContent"">
            "; 
        private const string _76_S_LITERAL_8 = @"
        </div>
    </div>
    <div class=""orangeStripe"" />
    <br />
    <div class=""tail"">
    </div>
</body>
</html>

"; 
        private const string _76_S_LITERAL_9 = @"
<a href=""index.htm"">Index</a> &nbsp; | &nbsp; Page rendered at "; 
        private const string _76_S_LITERAL_10 = @"

"; 
        private const string _76_S_LITERAL_11 = @"
<h1>A set of simple performance tests for NFX.Wave webserver</h1>*"; 
     #endregion

 }//class
}//namespace