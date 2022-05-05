/*
               File: Gx0061
        Description: Selection List Permite Almacenar configuracion de envio para mails mediante smtp
             Author: GeneXus C# Generator version 16_0_11-144151
       Generated on: 4/21/2022 10:26:32.99
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gx0061 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0061( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsSistema = context.GetDataStore("Sistema");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx0061( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsSistema = context.GetDataStore("Sistema");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_pAmGecod ,
                           out String aP1_pAmGeMailSec )
      {
         this.AV12pAmGecod = aP0_pAmGecod;
         this.AV13pAmGeMailSec = "" ;
         executePrivate();
         aP1_pAmGeMailSec=this.AV13pAmGeMailSec;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
            gxfirstwebparm_bkp = gxfirstwebparm;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
            {
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_GXsfl_74 = (int)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_74_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_74_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid1_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               subGrid1_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV6cAmGeMailSec = GetNextPar( );
               AV7cAmGeMailPort = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV8cAmGeMailHost = GetNextPar( );
               AV9cAmGeMailSender = GetNextPar( );
               AV10cAmgeMailUser = GetNextPar( );
               AV11cAmgeMailPassword = GetNextPar( );
               AV12pAmGecod = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cAmGeMailSec, AV7cAmGeMailPort, AV8cAmGeMailHost, AV9cAmGeMailSender, AV10cAmgeMailUser, AV11cAmgeMailPassword, AV12pAmGecod) ;
               AddString( context.getJSONResponse( )) ;
               return  ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp;
            }
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV12pAmGecod = gxfirstwebparm;
               AssignAttri("", false, "AV12pAmGecod", AV12pAmGecod);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV13pAmGeMailSec = GetNextPar( );
                  AssignAttri("", false, "AV13pAmGeMailSec", AV13pAmGeMailSec);
               }
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdpromptmasterpage", "GeneXus.Programs.rwdpromptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  AddString( context.getJSONResponse( )) ;
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA0C2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0C2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 144151), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 144151), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 144151), false, true);
         context.AddJavascriptSource("gxcfg.js", "?20224211026336", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0061.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pAmGecod)) + "," + UrlEncode(StringUtil.RTrim(AV13pAmGeMailSec))+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         AssignProp("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEMAILSEC", StringUtil.RTrim( AV6cAmGeMailSec));
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEMAILPORT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cAmGeMailPort), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEMAILHOST", AV8cAmGeMailHost);
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEMAILSENDER", AV9cAmGeMailSender);
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEMAILUSER", AV10cAmgeMailUser);
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEMAILPASSWORD", AV11cAmgeMailPassword);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPAMGECOD", StringUtil.RTrim( AV12pAmGecod));
         GxWebStd.gx_hidden_field( context, "vPAMGEMAILSEC", StringUtil.RTrim( AV13pAmGeMailSec));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "AMGEMAILSECFILTERCONTAINER_Class", StringUtil.RTrim( divAmgemailsecfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEMAILPORTFILTERCONTAINER_Class", StringUtil.RTrim( divAmgemailportfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEMAILHOSTFILTERCONTAINER_Class", StringUtil.RTrim( divAmgemailhostfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEMAILSENDERFILTERCONTAINER_Class", StringUtil.RTrim( divAmgemailsenderfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEMAILUSERFILTERCONTAINER_Class", StringUtil.RTrim( divAmgemailuserfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEMAILPASSWORDFILTERCONTAINER_Class", StringUtil.RTrim( divAmgemailpasswordfiltercontainer_Class));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", "notset");
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE0C2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0C2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx0061.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pAmGecod)) + "," + UrlEncode(StringUtil.RTrim(AV13pAmGeMailSec)) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0061" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Permite Almacenar configuracion de envio para mails mediante smtp" ;
      }

      protected void WB0C0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMain_Internalname, 1, 0, "px", 0, "px", "ContainerFluid PromptContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 PromptAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", divAdvancedcontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAmgemailsecfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgemailsecfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgemailsecfilter_Internalname, "Am Ge Mail Sec", "", "", lblLblamgemailsecfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e110c1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgemailsec_Internalname, "Am Ge Mail Sec", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgemailsec_Internalname, StringUtil.RTrim( AV6cAmGeMailSec), StringUtil.RTrim( context.localUtil.Format( AV6cAmGeMailSec, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgemailsec_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgemailsec_Visible, edtavCamgemailsec_Enabled, 0, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAmgemailportfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgemailportfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgemailportfilter_Internalname, "Puerto", "", "", lblLblamgemailportfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e120c1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgemailport_Internalname, "Puerto", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgemailport_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cAmGeMailPort), 4, 0, ",", "")), ((edtavCamgemailport_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cAmGeMailPort), "ZZZ9")) : context.localUtil.Format( (decimal)(AV7cAmGeMailPort), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgemailport_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgemailport_Visible, edtavCamgemailport_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAmgemailhostfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgemailhostfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgemailhostfilter_Internalname, "Am Ge Mail Host", "", "", lblLblamgemailhostfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e130c1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgemailhost_Internalname, "Am Ge Mail Host", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgemailhost_Internalname, AV8cAmGeMailHost, StringUtil.RTrim( context.localUtil.Format( AV8cAmGeMailHost, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgemailhost_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgemailhost_Visible, edtavCamgemailhost_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAmgemailsenderfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgemailsenderfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgemailsenderfilter_Internalname, "Am Ge Mail Sender", "", "", lblLblamgemailsenderfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e140c1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgemailsender_Internalname, "Am Ge Mail Sender", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgemailsender_Internalname, AV9cAmGeMailSender, StringUtil.RTrim( context.localUtil.Format( AV9cAmGeMailSender, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgemailsender_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgemailsender_Visible, edtavCamgemailsender_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAmgemailuserfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgemailuserfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgemailuserfilter_Internalname, "Amge Mail User", "", "", lblLblamgemailuserfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e150c1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgemailuser_Internalname, "Amge Mail User", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgemailuser_Internalname, AV10cAmgeMailUser, StringUtil.RTrim( context.localUtil.Format( AV10cAmgeMailUser, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgemailuser_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgemailuser_Visible, edtavCamgemailuser_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAmgemailpasswordfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgemailpasswordfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgemailpasswordfilter_Internalname, "Amge Mail Password", "", "", lblLblamgemailpasswordfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e160c1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgemailpassword_Internalname, "Amge Mail Password", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgemailpassword_Internalname, AV11cAmgeMailPassword, StringUtil.RTrim( context.localUtil.Format( AV11cAmgeMailPassword, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgemailpassword_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgemailpassword_Visible, edtavCamgemailpassword_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 WWGridCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg ToggleCell", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e170c1_client"+"'", TempTags, "", 2, "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"74\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "PromptGrid", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title";
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"SelectionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Mail Sec") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Puerto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Mail Host") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Mail Sender") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Codigo:") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Header", subGrid1_Header);
               Grid1Container.AddObjectProperty("Class", "PromptGrid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A43AmGeMailSec));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A44AmGeMailPort), 4, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtAmGeMailPort_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A45AmGeMailHost);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A46AmGeMailSender);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A1AmGecod));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            nRC_GXsfl_74 = (int)(nGXsfl_74_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0061.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid1Container.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
                  Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START0C2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            if ( context.ExposeMetadata( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_11-144151", 0) ;
            }
            Form.Meta.addItem("description", "Selection List Permite Almacenar configuracion de envio para mails mediante smtp", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0C0( ) ;
      }

      protected void WS0C2( )
      {
         START0C2( ) ;
         EVT0C2( ) ;
      }

      protected void EVT0C2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName");
               EvtGridId = cgiGet( "_EventGridId");
               EvtRowId = cgiGet( "_EventRowId");
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1);
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRID1PAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_74_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
                              SubsflControlProps_742( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              AssignProp("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_74_Refreshing);
                              AssignProp("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A43AmGeMailSec = cgiGet( edtAmGeMailSec_Internalname);
                              A44AmGeMailPort = (short)(context.localUtil.CToN( cgiGet( edtAmGeMailPort_Internalname), ",", "."));
                              A45AmGeMailHost = cgiGet( edtAmGeMailHost_Internalname);
                              A46AmGeMailSender = cgiGet( edtAmGeMailSender_Internalname);
                              A1AmGecod = cgiGet( edtAmGecod_Internalname);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E180C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E190C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Camgemailsec Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEMAILSEC"), AV6cAmGeMailSec) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgemailport Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAMGEMAILPORT"), ",", ".") != Convert.ToDecimal( AV7cAmGeMailPort )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgemailhost Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEMAILHOST"), AV8cAmGeMailHost) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgemailsender Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEMAILSENDER"), AV9cAmGeMailSender) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgemailuser Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEMAILUSER"), AV10cAmgeMailUser) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgemailpassword Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEMAILPASSWORD"), AV11cAmgeMailPassword) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E200C2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE0C2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA0C2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            init_web_controls( ) ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_742( ) ;
         while ( nGXsfl_74_idx <= nRC_GXsfl_74 )
         {
            sendrow_742( ) ;
            nGXsfl_74_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1);
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
            SubsflControlProps_742( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid1Container)) ;
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        String AV6cAmGeMailSec ,
                                        short AV7cAmGeMailPort ,
                                        String AV8cAmGeMailHost ,
                                        String AV9cAmGeMailSender ,
                                        String AV10cAmgeMailUser ,
                                        String AV11cAmgeMailPassword ,
                                        String AV12pAmGecod )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID1_nCurrentRecord = 0;
         RF0C2( ) ;
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         send_integrity_footer_hashes( ) ;
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_AMGEMAILSEC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A43AmGeMailSec, "")), context));
         GxWebStd.gx_hidden_field( context, "AMGEMAILSEC", StringUtil.RTrim( A43AmGeMailSec));
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
            before_start_formulas( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0C2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF0C2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 74;
         nGXsfl_74_idx = 1;
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
         SubsflControlProps_742( ) ;
         bGXsfl_74_Refreshing = true;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", "PromptGrid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_fnc_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_742( ) ;
            GXPagingFrom2 = (int)(GRID1_nFirstRecordOnPage);
            GXPagingTo2 = (int)(subGrid1_fnc_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cAmGeMailPort ,
                                                 AV8cAmGeMailHost ,
                                                 AV9cAmGeMailSender ,
                                                 AV10cAmgeMailUser ,
                                                 AV11cAmgeMailPassword ,
                                                 A44AmGeMailPort ,
                                                 A45AmGeMailHost ,
                                                 A46AmGeMailSender ,
                                                 A47AmgeMailUser ,
                                                 A48AmgeMailPassword ,
                                                 A43AmGeMailSec ,
                                                 AV6cAmGeMailSec ,
                                                 AV12pAmGecod ,
                                                 A1AmGecod } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                                 }
            } ) ;
            lV6cAmGeMailSec = StringUtil.PadR( StringUtil.RTrim( AV6cAmGeMailSec), 2, "%");
            lV8cAmGeMailHost = StringUtil.Concat( StringUtil.RTrim( AV8cAmGeMailHost), "%", "");
            lV9cAmGeMailSender = StringUtil.Concat( StringUtil.RTrim( AV9cAmGeMailSender), "%", "");
            lV10cAmgeMailUser = StringUtil.Concat( StringUtil.RTrim( AV10cAmgeMailUser), "%", "");
            lV11cAmgeMailPassword = StringUtil.Concat( StringUtil.RTrim( AV11cAmgeMailPassword), "%", "");
            /* Using cursor H000C2 */
            pr_default.execute(0, new Object[] {AV12pAmGecod, lV6cAmGeMailSec, AV7cAmGeMailPort, lV8cAmGeMailHost, lV9cAmGeMailSender, lV10cAmgeMailUser, lV11cAmgeMailPassword, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_74_idx = 1;
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
            SubsflControlProps_742( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( GRID1_nCurrentRecord < subGrid1_fnc_Recordsperpage( ) ) ) )
            {
               A48AmgeMailPassword = H000C2_A48AmgeMailPassword[0];
               A47AmgeMailUser = H000C2_A47AmgeMailUser[0];
               A1AmGecod = H000C2_A1AmGecod[0];
               A46AmGeMailSender = H000C2_A46AmGeMailSender[0];
               A45AmGeMailHost = H000C2_A45AmGeMailHost[0];
               A44AmGeMailPort = H000C2_A44AmGeMailPort[0];
               A43AmGeMailSec = H000C2_A43AmGeMailSec[0];
               /* Execute user event: Load */
               E190C2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB0C0( ) ;
         }
         bGXsfl_74_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0C2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_AMGEMAILSEC"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, StringUtil.RTrim( context.localUtil.Format( A43AmGeMailSec, "")), context));
      }

      protected int subGrid1_fnc_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( ((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_fnc_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_fnc_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_fnc_Recordcount( )
      {
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV7cAmGeMailPort ,
                                              AV8cAmGeMailHost ,
                                              AV9cAmGeMailSender ,
                                              AV10cAmgeMailUser ,
                                              AV11cAmgeMailPassword ,
                                              A44AmGeMailPort ,
                                              A45AmGeMailHost ,
                                              A46AmGeMailSender ,
                                              A47AmgeMailUser ,
                                              A48AmgeMailPassword ,
                                              A43AmGeMailSec ,
                                              AV6cAmGeMailSec ,
                                              AV12pAmGecod ,
                                              A1AmGecod } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV6cAmGeMailSec = StringUtil.PadR( StringUtil.RTrim( AV6cAmGeMailSec), 2, "%");
         lV8cAmGeMailHost = StringUtil.Concat( StringUtil.RTrim( AV8cAmGeMailHost), "%", "");
         lV9cAmGeMailSender = StringUtil.Concat( StringUtil.RTrim( AV9cAmGeMailSender), "%", "");
         lV10cAmgeMailUser = StringUtil.Concat( StringUtil.RTrim( AV10cAmgeMailUser), "%", "");
         lV11cAmgeMailPassword = StringUtil.Concat( StringUtil.RTrim( AV11cAmgeMailPassword), "%", "");
         /* Using cursor H000C3 */
         pr_default.execute(1, new Object[] {AV12pAmGecod, lV6cAmGeMailSec, AV7cAmGeMailPort, lV8cAmGeMailHost, lV9cAmGeMailSender, lV10cAmgeMailUser, lV11cAmgeMailPassword});
         GRID1_nRecordCount = H000C3_AGRID1_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID1_nRecordCount) ;
      }

      protected int subGrid1_fnc_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGrid1_fnc_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_fnc_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmGeMailSec, AV7cAmGeMailPort, AV8cAmGeMailHost, AV9cAmGeMailSender, AV10cAmgeMailUser, AV11cAmgeMailPassword, AV12pAmGecod) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( ( GRID1_nRecordCount >= subGrid1_fnc_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage+subGrid1_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmGeMailSec, AV7cAmGeMailPort, AV8cAmGeMailHost, AV9cAmGeMailSender, AV10cAmgeMailUser, AV11cAmgeMailPassword, AV12pAmGecod) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID1_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_fnc_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage-subGrid1_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmGeMailSec, AV7cAmGeMailPort, AV8cAmGeMailHost, AV9cAmGeMailSender, AV10cAmgeMailUser, AV11cAmgeMailPassword, AV12pAmGecod) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( GRID1_nRecordCount > subGrid1_fnc_Recordsperpage( ) )
         {
            if ( ((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-subGrid1_fnc_Recordsperpage( ));
            }
            else
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))));
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmGeMailSec, AV7cAmGeMailPort, AV8cAmGeMailHost, AV9cAmGeMailSender, AV10cAmgeMailUser, AV11cAmgeMailPassword, AV12pAmGecod) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (long)(subGrid1_fnc_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmGeMailSec, AV7cAmGeMailPort, AV8cAmGeMailHost, AV9cAmGeMailSender, AV10cAmgeMailUser, AV11cAmgeMailPassword, AV12pAmGecod) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void before_start_formulas( )
      {
         context.Gx_err = 0;
      }

      protected void STRUP0C0( )
      {
         /* Before Start, stand alone formulas. */
         before_start_formulas( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E180C2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_74 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read variables values. */
            AV6cAmGeMailSec = cgiGet( edtavCamgemailsec_Internalname);
            AssignAttri("", false, "AV6cAmGeMailSec", AV6cAmGeMailSec);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCamgemailport_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCamgemailport_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCAMGEMAILPORT");
               GX_FocusControl = edtavCamgemailport_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cAmGeMailPort = 0;
               AssignAttri("", false, "AV7cAmGeMailPort", StringUtil.LTrimStr( (decimal)(AV7cAmGeMailPort), 4, 0));
            }
            else
            {
               AV7cAmGeMailPort = (short)(context.localUtil.CToN( cgiGet( edtavCamgemailport_Internalname), ",", "."));
               AssignAttri("", false, "AV7cAmGeMailPort", StringUtil.LTrimStr( (decimal)(AV7cAmGeMailPort), 4, 0));
            }
            AV8cAmGeMailHost = cgiGet( edtavCamgemailhost_Internalname);
            AssignAttri("", false, "AV8cAmGeMailHost", AV8cAmGeMailHost);
            AV9cAmGeMailSender = cgiGet( edtavCamgemailsender_Internalname);
            AssignAttri("", false, "AV9cAmGeMailSender", AV9cAmGeMailSender);
            AV10cAmgeMailUser = cgiGet( edtavCamgemailuser_Internalname);
            AssignAttri("", false, "AV10cAmgeMailUser", AV10cAmgeMailUser);
            AV11cAmgeMailPassword = cgiGet( edtavCamgemailpassword_Internalname);
            AssignAttri("", false, "AV11cAmgeMailPassword", AV11cAmgeMailPassword);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEMAILSEC"), AV6cAmGeMailSec) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAMGEMAILPORT"), ",", ".") != Convert.ToDecimal( AV7cAmGeMailPort )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEMAILHOST"), AV8cAmGeMailHost) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEMAILSENDER"), AV9cAmGeMailSender) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEMAILUSER"), AV10cAmgeMailUser) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEMAILPASSWORD"), AV11cAmgeMailPassword) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E180C2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E180C2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Permite Almacenar configuracion de envio para mails mediante smtp", "", "", "", "", "", "", "", "");
         AssignProp("", false, "FORM", "Caption", Form.Caption, true);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E190C2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         AssignAttri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV17Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_742( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_74_Refreshing )
         {
            context.DoAjaxLoad(74, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E200C2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E200C2( )
      {
         /* Enter Routine */
         AV13pAmGeMailSec = A43AmGeMailSec;
         AssignAttri("", false, "AV13pAmGeMailSec", AV13pAmGeMailSec);
         context.setWebReturnParms(new Object[] {(String)AV13pAmGeMailSec});
         context.setWebReturnParmsMetadata(new Object[] {"AV13pAmGeMailSec"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pAmGecod = (String)getParm(obj,0);
         AssignAttri("", false, "AV12pAmGecod", AV12pAmGecod);
         AV13pAmGeMailSec = (String)getParm(obj,1);
         AssignAttri("", false, "AV13pAmGeMailSec", AV13pAmGeMailSec);
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA0C2( ) ;
         WS0C2( ) ;
         WE0C2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202242110263372", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("gx0061.js", "?202242110263372", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtAmGeMailSec_Internalname = "AMGEMAILSEC_"+sGXsfl_74_idx;
         edtAmGeMailPort_Internalname = "AMGEMAILPORT_"+sGXsfl_74_idx;
         edtAmGeMailHost_Internalname = "AMGEMAILHOST_"+sGXsfl_74_idx;
         edtAmGeMailSender_Internalname = "AMGEMAILSENDER_"+sGXsfl_74_idx;
         edtAmGecod_Internalname = "AMGECOD_"+sGXsfl_74_idx;
      }

      protected void SubsflControlProps_fel_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_fel_idx;
         edtAmGeMailSec_Internalname = "AMGEMAILSEC_"+sGXsfl_74_fel_idx;
         edtAmGeMailPort_Internalname = "AMGEMAILPORT_"+sGXsfl_74_fel_idx;
         edtAmGeMailHost_Internalname = "AMGEMAILHOST_"+sGXsfl_74_fel_idx;
         edtAmGeMailSender_Internalname = "AMGEMAILSENDER_"+sGXsfl_74_fel_idx;
         edtAmGecod_Internalname = "AMGECOD_"+sGXsfl_74_fel_idx;
      }

      protected void sendrow_742( )
      {
         SubsflControlProps_742( ) ;
         WB0C0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_74_idx <= subGrid1_fnc_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container);
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0;
               subGrid1_Backcolor = subGrid1_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform";
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
               subGrid1_Backcolor = (int)(0x0);
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( ((int)((nGXsfl_74_idx) % (2))) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even";
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd";
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"PromptGrid"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_74_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A43AmGeMailSec))+"'"+"]);";
            AssignProp("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_74_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV17Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGeMailSec_Internalname,StringUtil.RTrim( A43AmGeMailSec),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmGeMailSec_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtAmGeMailPort_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A43AmGeMailSec))+"'"+"]);";
            AssignProp("", false, edtAmGeMailPort_Internalname, "Link", edtAmGeMailPort_Link, !bGXsfl_74_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGeMailPort_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A44AmGeMailPort), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A44AmGeMailPort), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtAmGeMailPort_Link,(String)"",(String)"",(String)"",(String)edtAmGeMailPort_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGeMailHost_Internalname,(String)A45AmGeMailHost,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmGeMailHost_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGeMailSender_Internalname,(String)A46AmGeMailSender,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmGeMailSender_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGecod_Internalname,StringUtil.RTrim( A1AmGecod),StringUtil.RTrim( context.localUtil.Format( A1AmGecod, "99999")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmGecod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"codmediano",(String)"left",(bool)true,(String)""});
            send_integrity_lvl_hashes0C2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1);
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
            SubsflControlProps_742( ) ;
         }
         /* End function sendrow_742 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblLblamgemailsecfilter_Internalname = "LBLAMGEMAILSECFILTER";
         edtavCamgemailsec_Internalname = "vCAMGEMAILSEC";
         divAmgemailsecfiltercontainer_Internalname = "AMGEMAILSECFILTERCONTAINER";
         lblLblamgemailportfilter_Internalname = "LBLAMGEMAILPORTFILTER";
         edtavCamgemailport_Internalname = "vCAMGEMAILPORT";
         divAmgemailportfiltercontainer_Internalname = "AMGEMAILPORTFILTERCONTAINER";
         lblLblamgemailhostfilter_Internalname = "LBLAMGEMAILHOSTFILTER";
         edtavCamgemailhost_Internalname = "vCAMGEMAILHOST";
         divAmgemailhostfiltercontainer_Internalname = "AMGEMAILHOSTFILTERCONTAINER";
         lblLblamgemailsenderfilter_Internalname = "LBLAMGEMAILSENDERFILTER";
         edtavCamgemailsender_Internalname = "vCAMGEMAILSENDER";
         divAmgemailsenderfiltercontainer_Internalname = "AMGEMAILSENDERFILTERCONTAINER";
         lblLblamgemailuserfilter_Internalname = "LBLAMGEMAILUSERFILTER";
         edtavCamgemailuser_Internalname = "vCAMGEMAILUSER";
         divAmgemailuserfiltercontainer_Internalname = "AMGEMAILUSERFILTERCONTAINER";
         lblLblamgemailpasswordfilter_Internalname = "LBLAMGEMAILPASSWORDFILTER";
         edtavCamgemailpassword_Internalname = "vCAMGEMAILPASSWORD";
         divAmgemailpasswordfiltercontainer_Internalname = "AMGEMAILPASSWORDFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtAmGeMailSec_Internalname = "AMGEMAILSEC";
         edtAmGeMailPort_Internalname = "AMGEMAILPORT";
         edtAmGeMailHost_Internalname = "AMGEMAILHOST";
         edtAmGeMailSender_Internalname = "AMGEMAILSENDER";
         edtAmGecod_Internalname = "AMGECOD";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         divGridtable_Internalname = "GRIDTABLE";
         divMain_Internalname = "MAIN";
         Form.Internalname = "FORM";
         subGrid1_Internalname = "GRID1";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtAmGecod_Jsonclick = "";
         edtAmGeMailSender_Jsonclick = "";
         edtAmGeMailHost_Jsonclick = "";
         edtAmGeMailPort_Jsonclick = "";
         edtAmGeMailSec_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtAmGeMailPort_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCamgemailpassword_Jsonclick = "";
         edtavCamgemailpassword_Enabled = 1;
         edtavCamgemailpassword_Visible = 1;
         edtavCamgemailuser_Jsonclick = "";
         edtavCamgemailuser_Enabled = 1;
         edtavCamgemailuser_Visible = 1;
         edtavCamgemailsender_Jsonclick = "";
         edtavCamgemailsender_Enabled = 1;
         edtavCamgemailsender_Visible = 1;
         edtavCamgemailhost_Jsonclick = "";
         edtavCamgemailhost_Enabled = 1;
         edtavCamgemailhost_Visible = 1;
         edtavCamgemailport_Jsonclick = "";
         edtavCamgemailport_Enabled = 1;
         edtavCamgemailport_Visible = 1;
         edtavCamgemailsec_Jsonclick = "";
         edtavCamgemailsec_Enabled = 1;
         edtavCamgemailsec_Visible = 1;
         divAmgemailpasswordfiltercontainer_Class = "AdvancedContainerItem";
         divAmgemailuserfiltercontainer_Class = "AdvancedContainerItem";
         divAmgemailsenderfiltercontainer_Class = "AdvancedContainerItem";
         divAmgemailhostfiltercontainer_Class = "AdvancedContainerItem";
         divAmgemailportfiltercontainer_Class = "AdvancedContainerItem";
         divAmgemailsecfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Permite Almacenar configuracion de envio para mails mediante smtp";
         subGrid1_Rows = 10;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmGeMailSec',fld:'vCAMGEMAILSEC',pic:''},{av:'AV7cAmGeMailPort',fld:'vCAMGEMAILPORT',pic:'ZZZ9'},{av:'AV8cAmGeMailHost',fld:'vCAMGEMAILHOST',pic:''},{av:'AV9cAmGeMailSender',fld:'vCAMGEMAILSENDER',pic:''},{av:'AV10cAmgeMailUser',fld:'vCAMGEMAILUSER',pic:''},{av:'AV11cAmgeMailPassword',fld:'vCAMGEMAILPASSWORD',pic:''},{av:'AV12pAmGecod',fld:'vPAMGECOD',pic:'99999'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E170C1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLAMGEMAILSECFILTER.CLICK","{handler:'E110C1',iparms:[{av:'divAmgemailsecfiltercontainer_Class',ctrl:'AMGEMAILSECFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEMAILSECFILTER.CLICK",",oparms:[{av:'divAmgemailsecfiltercontainer_Class',ctrl:'AMGEMAILSECFILTERCONTAINER',prop:'Class'},{av:'edtavCamgemailsec_Visible',ctrl:'vCAMGEMAILSEC',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEMAILPORTFILTER.CLICK","{handler:'E120C1',iparms:[{av:'divAmgemailportfiltercontainer_Class',ctrl:'AMGEMAILPORTFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEMAILPORTFILTER.CLICK",",oparms:[{av:'divAmgemailportfiltercontainer_Class',ctrl:'AMGEMAILPORTFILTERCONTAINER',prop:'Class'},{av:'edtavCamgemailport_Visible',ctrl:'vCAMGEMAILPORT',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEMAILHOSTFILTER.CLICK","{handler:'E130C1',iparms:[{av:'divAmgemailhostfiltercontainer_Class',ctrl:'AMGEMAILHOSTFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEMAILHOSTFILTER.CLICK",",oparms:[{av:'divAmgemailhostfiltercontainer_Class',ctrl:'AMGEMAILHOSTFILTERCONTAINER',prop:'Class'},{av:'edtavCamgemailhost_Visible',ctrl:'vCAMGEMAILHOST',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEMAILSENDERFILTER.CLICK","{handler:'E140C1',iparms:[{av:'divAmgemailsenderfiltercontainer_Class',ctrl:'AMGEMAILSENDERFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEMAILSENDERFILTER.CLICK",",oparms:[{av:'divAmgemailsenderfiltercontainer_Class',ctrl:'AMGEMAILSENDERFILTERCONTAINER',prop:'Class'},{av:'edtavCamgemailsender_Visible',ctrl:'vCAMGEMAILSENDER',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEMAILUSERFILTER.CLICK","{handler:'E150C1',iparms:[{av:'divAmgemailuserfiltercontainer_Class',ctrl:'AMGEMAILUSERFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEMAILUSERFILTER.CLICK",",oparms:[{av:'divAmgemailuserfiltercontainer_Class',ctrl:'AMGEMAILUSERFILTERCONTAINER',prop:'Class'},{av:'edtavCamgemailuser_Visible',ctrl:'vCAMGEMAILUSER',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEMAILPASSWORDFILTER.CLICK","{handler:'E160C1',iparms:[{av:'divAmgemailpasswordfiltercontainer_Class',ctrl:'AMGEMAILPASSWORDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEMAILPASSWORDFILTER.CLICK",",oparms:[{av:'divAmgemailpasswordfiltercontainer_Class',ctrl:'AMGEMAILPASSWORDFILTERCONTAINER',prop:'Class'},{av:'edtavCamgemailpassword_Visible',ctrl:'vCAMGEMAILPASSWORD',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E200C2',iparms:[{av:'A43AmGeMailSec',fld:'AMGEMAILSEC',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV13pAmGeMailSec',fld:'vPAMGEMAILSEC',pic:''}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmGeMailSec',fld:'vCAMGEMAILSEC',pic:''},{av:'AV7cAmGeMailPort',fld:'vCAMGEMAILPORT',pic:'ZZZ9'},{av:'AV8cAmGeMailHost',fld:'vCAMGEMAILHOST',pic:''},{av:'AV9cAmGeMailSender',fld:'vCAMGEMAILSENDER',pic:''},{av:'AV10cAmgeMailUser',fld:'vCAMGEMAILUSER',pic:''},{av:'AV11cAmgeMailPassword',fld:'vCAMGEMAILPASSWORD',pic:''},{av:'AV12pAmGecod',fld:'vPAMGECOD',pic:'99999'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmGeMailSec',fld:'vCAMGEMAILSEC',pic:''},{av:'AV7cAmGeMailPort',fld:'vCAMGEMAILPORT',pic:'ZZZ9'},{av:'AV8cAmGeMailHost',fld:'vCAMGEMAILHOST',pic:''},{av:'AV9cAmGeMailSender',fld:'vCAMGEMAILSENDER',pic:''},{av:'AV10cAmgeMailUser',fld:'vCAMGEMAILUSER',pic:''},{av:'AV11cAmgeMailPassword',fld:'vCAMGEMAILPASSWORD',pic:''},{av:'AV12pAmGecod',fld:'vPAMGECOD',pic:'99999'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmGeMailSec',fld:'vCAMGEMAILSEC',pic:''},{av:'AV7cAmGeMailPort',fld:'vCAMGEMAILPORT',pic:'ZZZ9'},{av:'AV8cAmGeMailHost',fld:'vCAMGEMAILHOST',pic:''},{av:'AV9cAmGeMailSender',fld:'vCAMGEMAILSENDER',pic:''},{av:'AV10cAmgeMailUser',fld:'vCAMGEMAILUSER',pic:''},{av:'AV11cAmgeMailPassword',fld:'vCAMGEMAILPASSWORD',pic:''},{av:'AV12pAmGecod',fld:'vPAMGECOD',pic:'99999'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmGeMailSec',fld:'vCAMGEMAILSEC',pic:''},{av:'AV7cAmGeMailPort',fld:'vCAMGEMAILPORT',pic:'ZZZ9'},{av:'AV8cAmGeMailHost',fld:'vCAMGEMAILHOST',pic:''},{av:'AV9cAmGeMailSender',fld:'vCAMGEMAILSENDER',pic:''},{av:'AV10cAmgeMailUser',fld:'vCAMGEMAILUSER',pic:''},{av:'AV11cAmgeMailPassword',fld:'vCAMGEMAILPASSWORD',pic:''},{av:'AV12pAmGecod',fld:'vPAMGECOD',pic:'99999'}]");
         setEventMetadata("GRID1_LASTPAGE",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Amgecod',iparms:[]");
         setEventMetadata("NULL",",oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         wcpOAV12pAmGecod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV6cAmGeMailSec = "";
         AV8cAmGeMailHost = "";
         AV9cAmGeMailSender = "";
         AV10cAmgeMailUser = "";
         AV11cAmgeMailPassword = "";
         AV13pAmGeMailSec = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblamgemailsecfilter_Jsonclick = "";
         TempTags = "";
         lblLblamgemailportfilter_Jsonclick = "";
         lblLblamgemailhostfilter_Jsonclick = "";
         lblLblamgemailsenderfilter_Jsonclick = "";
         lblLblamgemailuserfilter_Jsonclick = "";
         lblLblamgemailpasswordfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A43AmGeMailSec = "";
         A45AmGeMailHost = "";
         A46AmGeMailSender = "";
         A1AmGecod = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         scmdbuf = "";
         lV6cAmGeMailSec = "";
         lV8cAmGeMailHost = "";
         lV9cAmGeMailSender = "";
         lV10cAmgeMailUser = "";
         lV11cAmgeMailPassword = "";
         A47AmgeMailUser = "";
         A48AmgeMailPassword = "";
         H000C2_A48AmgeMailPassword = new String[] {""} ;
         H000C2_A47AmgeMailUser = new String[] {""} ;
         H000C2_A1AmGecod = new String[] {""} ;
         H000C2_A46AmGeMailSender = new String[] {""} ;
         H000C2_A45AmGeMailHost = new String[] {""} ;
         H000C2_A44AmGeMailPort = new short[1] ;
         H000C2_A43AmGeMailSec = new String[] {""} ;
         H000C3_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0061__default(),
            new Object[][] {
                new Object[] {
               H000C2_A48AmgeMailPassword, H000C2_A47AmgeMailUser, H000C2_A1AmGecod, H000C2_A46AmGeMailSender, H000C2_A45AmGeMailHost, H000C2_A44AmGeMailPort, H000C2_A43AmGeMailSec
               }
               , new Object[] {
               H000C3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short GRID1_nEOF ;
      private short nGotPars ;
      private short GxWebError ;
      private short AV7cAmGeMailPort ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A44AmGeMailPort ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int nRC_GXsfl_74 ;
      private int nGXsfl_74_idx=1 ;
      private int subGrid1_Rows ;
      private int edtavCamgemailsec_Visible ;
      private int edtavCamgemailsec_Enabled ;
      private int edtavCamgemailport_Enabled ;
      private int edtavCamgemailport_Visible ;
      private int edtavCamgemailhost_Visible ;
      private int edtavCamgemailhost_Enabled ;
      private int edtavCamgemailsender_Visible ;
      private int edtavCamgemailsender_Enabled ;
      private int edtavCamgemailuser_Visible ;
      private int edtavCamgemailuser_Enabled ;
      private int edtavCamgemailpassword_Visible ;
      private int edtavCamgemailpassword_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String AV12pAmGecod ;
      private String wcpOAV12pAmGecod ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divAmgemailsecfiltercontainer_Class ;
      private String divAmgemailportfiltercontainer_Class ;
      private String divAmgemailhostfiltercontainer_Class ;
      private String divAmgemailsenderfiltercontainer_Class ;
      private String divAmgemailuserfiltercontainer_Class ;
      private String divAmgemailpasswordfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_74_idx="0001" ;
      private String AV6cAmGeMailSec ;
      private String AV13pAmGeMailSec ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divAmgemailsecfiltercontainer_Internalname ;
      private String lblLblamgemailsecfilter_Internalname ;
      private String lblLblamgemailsecfilter_Jsonclick ;
      private String edtavCamgemailsec_Internalname ;
      private String TempTags ;
      private String edtavCamgemailsec_Jsonclick ;
      private String divAmgemailportfiltercontainer_Internalname ;
      private String lblLblamgemailportfilter_Internalname ;
      private String lblLblamgemailportfilter_Jsonclick ;
      private String edtavCamgemailport_Internalname ;
      private String edtavCamgemailport_Jsonclick ;
      private String divAmgemailhostfiltercontainer_Internalname ;
      private String lblLblamgemailhostfilter_Internalname ;
      private String lblLblamgemailhostfilter_Jsonclick ;
      private String edtavCamgemailhost_Internalname ;
      private String edtavCamgemailhost_Jsonclick ;
      private String divAmgemailsenderfiltercontainer_Internalname ;
      private String lblLblamgemailsenderfilter_Internalname ;
      private String lblLblamgemailsenderfilter_Jsonclick ;
      private String edtavCamgemailsender_Internalname ;
      private String edtavCamgemailsender_Jsonclick ;
      private String divAmgemailuserfiltercontainer_Internalname ;
      private String lblLblamgemailuserfilter_Internalname ;
      private String lblLblamgemailuserfilter_Jsonclick ;
      private String edtavCamgemailuser_Internalname ;
      private String edtavCamgemailuser_Jsonclick ;
      private String divAmgemailpasswordfiltercontainer_Internalname ;
      private String lblLblamgemailpasswordfilter_Internalname ;
      private String lblLblamgemailpasswordfilter_Jsonclick ;
      private String edtavCamgemailpassword_Internalname ;
      private String edtavCamgemailpassword_Jsonclick ;
      private String divGridtable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String subGrid1_Header ;
      private String edtavLinkselection_Link ;
      private String A43AmGeMailSec ;
      private String edtAmGeMailPort_Link ;
      private String A1AmGecod ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtAmGeMailSec_Internalname ;
      private String edtAmGeMailPort_Internalname ;
      private String edtAmGeMailHost_Internalname ;
      private String edtAmGeMailSender_Internalname ;
      private String edtAmGecod_Internalname ;
      private String scmdbuf ;
      private String lV6cAmGeMailSec ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_74_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtAmGeMailSec_Jsonclick ;
      private String edtAmGeMailPort_Jsonclick ;
      private String edtAmGeMailHost_Jsonclick ;
      private String edtAmGeMailSender_Jsonclick ;
      private String edtAmGecod_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_74_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV8cAmGeMailHost ;
      private String AV9cAmGeMailSender ;
      private String AV10cAmgeMailUser ;
      private String AV11cAmgeMailPassword ;
      private String A45AmGeMailHost ;
      private String A46AmGeMailSender ;
      private String AV17Linkselection_GXI ;
      private String lV8cAmGeMailHost ;
      private String lV9cAmGeMailSender ;
      private String lV10cAmgeMailUser ;
      private String lV11cAmgeMailPassword ;
      private String A47AmgeMailUser ;
      private String A48AmgeMailPassword ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsSistema ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H000C2_A48AmgeMailPassword ;
      private String[] H000C2_A47AmgeMailUser ;
      private String[] H000C2_A1AmGecod ;
      private String[] H000C2_A46AmGeMailSender ;
      private String[] H000C2_A45AmGeMailHost ;
      private short[] H000C2_A44AmGeMailPort ;
      private String[] H000C2_A43AmGeMailSec ;
      private long[] H000C3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP1_pAmGeMailSec ;
      private GXWebForm Form ;
   }

   public class gx0061__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000C2( IGxContext context ,
                                             short AV7cAmGeMailPort ,
                                             String AV8cAmGeMailHost ,
                                             String AV9cAmGeMailSender ,
                                             String AV10cAmgeMailUser ,
                                             String AV11cAmgeMailPassword ,
                                             short A44AmGeMailPort ,
                                             String A45AmGeMailHost ,
                                             String A46AmGeMailSender ,
                                             String A47AmgeMailUser ,
                                             String A48AmgeMailPassword ,
                                             String A43AmGeMailSec ,
                                             String AV6cAmGeMailSec ,
                                             String AV12pAmGecod ,
                                             String A1AmGecod )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [10] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [AmgeMailPassword], [AmgeMailUser], [AmGecod], [AmGeMailSender], [AmGeMailHost], [AmGeMailPort], [AmGeMailSec]";
         sFromString = " FROM [AgAmGe4]";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([AmGecod] = @AV12pAmGecod)";
         sWhereString = sWhereString + " and ([AmGeMailSec] like @lV6cAmGeMailSec)";
         if ( ! (0==AV7cAmGeMailPort) )
         {
            sWhereString = sWhereString + " and ([AmGeMailPort] >= @AV7cAmGeMailPort)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cAmGeMailHost)) )
         {
            sWhereString = sWhereString + " and ([AmGeMailHost] like @lV8cAmGeMailHost)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cAmGeMailSender)) )
         {
            sWhereString = sWhereString + " and ([AmGeMailSender] like @lV9cAmGeMailSender)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cAmgeMailUser)) )
         {
            sWhereString = sWhereString + " and ([AmgeMailUser] like @lV10cAmgeMailUser)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cAmgeMailPassword)) )
         {
            sWhereString = sWhereString + " and ([AmgeMailPassword] like @lV11cAmgeMailPassword)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [AmGecod], [AmGeMailSec]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + sOrderString + "" + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H000C3( IGxContext context ,
                                             short AV7cAmGeMailPort ,
                                             String AV8cAmGeMailHost ,
                                             String AV9cAmGeMailSender ,
                                             String AV10cAmgeMailUser ,
                                             String AV11cAmgeMailPassword ,
                                             short A44AmGeMailPort ,
                                             String A45AmGeMailHost ,
                                             String A46AmGeMailSender ,
                                             String A47AmgeMailUser ,
                                             String A48AmgeMailPassword ,
                                             String A43AmGeMailSec ,
                                             String AV6cAmGeMailSec ,
                                             String AV12pAmGecod ,
                                             String A1AmGecod )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [AgAmGe4]";
         scmdbuf = scmdbuf + " WHERE ([AmGecod] = @AV12pAmGecod)";
         scmdbuf = scmdbuf + " and ([AmGeMailSec] like @lV6cAmGeMailSec)";
         if ( ! (0==AV7cAmGeMailPort) )
         {
            sWhereString = sWhereString + " and ([AmGeMailPort] >= @AV7cAmGeMailPort)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cAmGeMailHost)) )
         {
            sWhereString = sWhereString + " and ([AmGeMailHost] like @lV8cAmGeMailHost)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cAmGeMailSender)) )
         {
            sWhereString = sWhereString + " and ([AmGeMailSender] like @lV9cAmGeMailSender)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cAmgeMailUser)) )
         {
            sWhereString = sWhereString + " and ([AmgeMailUser] like @lV10cAmgeMailUser)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cAmgeMailPassword)) )
         {
            sWhereString = sWhereString + " and ([AmgeMailPassword] like @lV11cAmgeMailPassword)";
         }
         else
         {
            GXv_int3[6] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H000C2(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] );
               case 1 :
                     return conditional_H000C3(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000C2 ;
          prmH000C2 = new Object[] {
          new Object[] {"@AV12pAmGecod",SqlDbType.NChar,5,0} ,
          new Object[] {"@lV6cAmGeMailSec",SqlDbType.NChar,2,0} ,
          new Object[] {"@AV7cAmGeMailPort",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV8cAmGeMailHost",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@lV9cAmGeMailSender",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@lV10cAmgeMailUser",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@lV11cAmgeMailPassword",SqlDbType.NVarChar,60,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000C3 ;
          prmH000C3 = new Object[] {
          new Object[] {"@AV12pAmGecod",SqlDbType.NChar,5,0} ,
          new Object[] {"@lV6cAmGeMailSec",SqlDbType.NChar,2,0} ,
          new Object[] {"@AV7cAmGeMailPort",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV8cAmGeMailHost",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@lV9cAmGeMailSender",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@lV10cAmgeMailUser",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@lV11cAmgeMailPassword",SqlDbType.NVarChar,60,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000C2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C2,11, GxCacheFrequency.OFF ,false,false )
             ,new CursorDef("H000C3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C3,1, GxCacheFrequency.OFF ,false,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 5) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 2) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                return;
       }
    }

 }

}
