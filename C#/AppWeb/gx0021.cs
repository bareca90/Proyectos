/*
               File: Gx0021
        Description: Selection List Detalle de Configuracion WebServices
             Author: GeneXus C# Generator version 16_0_11-144151
       Generated on: 4/21/2022 10:26:32.70
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
   public class gx0021 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0021( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsSistema = context.GetDataStore("Sistema");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx0021( IGxContext context )
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
                           out String aP1_pAmgewsSec )
      {
         this.AV12pAmGecod = aP0_pAmGecod;
         this.AV13pAmgewsSec = "" ;
         executePrivate();
         aP1_pAmgewsSec=this.AV13pAmgewsSec;
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
               AV6cAmgewsSec = GetNextPar( );
               AV7cAmgeWsPort = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV8cAmgeWsHost = GetNextPar( );
               AV9cAmgeWsLoc = GetNextPar( );
               AV10cAmgeWsTip = GetNextPar( );
               AV11cAmgeWsEst = GetNextPar( );
               AV12pAmGecod = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cAmgewsSec, AV7cAmgeWsPort, AV8cAmgeWsHost, AV9cAmgeWsLoc, AV10cAmgeWsTip, AV11cAmgeWsEst, AV12pAmGecod) ;
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
                  AV13pAmgewsSec = GetNextPar( );
                  AssignAttri("", false, "AV13pAmgewsSec", AV13pAmgewsSec);
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
         PA092( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START092( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202242110263278", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0021.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pAmGecod)) + "," + UrlEncode(StringUtil.RTrim(AV13pAmgewsSec))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEWSSEC", StringUtil.RTrim( AV6cAmgewsSec));
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEWSPORT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cAmgeWsPort), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEWSHOST", StringUtil.RTrim( AV8cAmgeWsHost));
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEWSLOC", StringUtil.RTrim( AV9cAmgeWsLoc));
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEWSTIP", StringUtil.RTrim( AV10cAmgeWsTip));
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEWSEST", StringUtil.RTrim( AV11cAmgeWsEst));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPAMGECOD", StringUtil.RTrim( AV12pAmGecod));
         GxWebStd.gx_hidden_field( context, "vPAMGEWSSEC", StringUtil.RTrim( AV13pAmgewsSec));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "AMGEWSSECFILTERCONTAINER_Class", StringUtil.RTrim( divAmgewssecfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEWSPORTFILTERCONTAINER_Class", StringUtil.RTrim( divAmgewsportfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEWSHOSTFILTERCONTAINER_Class", StringUtil.RTrim( divAmgewshostfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEWSLOCFILTERCONTAINER_Class", StringUtil.RTrim( divAmgewslocfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEWSTIPFILTERCONTAINER_Class", StringUtil.RTrim( divAmgewstipfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEWSESTFILTERCONTAINER_Class", StringUtil.RTrim( divAmgewsestfiltercontainer_Class));
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
            WE092( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT092( ) ;
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
         return formatLink("gx0021.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pAmGecod)) + "," + UrlEncode(StringUtil.RTrim(AV13pAmgewsSec)) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0021" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Detalle de Configuracion WebServices" ;
      }

      protected void WB090( )
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
            GxWebStd.gx_div_start( context, divAmgewssecfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgewssecfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgewssecfilter_Internalname, "Secuencia", "", "", lblLblamgewssecfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11091_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0021.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgewssec_Internalname, "Secuencia", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgewssec_Internalname, StringUtil.RTrim( AV6cAmgewsSec), StringUtil.RTrim( context.localUtil.Format( AV6cAmgewsSec, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgewssec_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgewssec_Visible, edtavCamgewssec_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0021.htm");
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
            GxWebStd.gx_div_start( context, divAmgewsportfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgewsportfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgewsportfilter_Internalname, "Puerto", "", "", lblLblamgewsportfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12091_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0021.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgewsport_Internalname, "Puerto", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgewsport_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cAmgeWsPort), 4, 0, ",", "")), ((edtavCamgewsport_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cAmgeWsPort), "ZZZ9")) : context.localUtil.Format( (decimal)(AV7cAmgeWsPort), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgewsport_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgewsport_Visible, edtavCamgewsport_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0021.htm");
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
            GxWebStd.gx_div_start( context, divAmgewshostfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgewshostfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgewshostfilter_Internalname, "Host", "", "", lblLblamgewshostfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13091_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0021.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgewshost_Internalname, "Host", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgewshost_Internalname, StringUtil.RTrim( AV8cAmgeWsHost), StringUtil.RTrim( context.localUtil.Format( AV8cAmgeWsHost, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgewshost_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgewshost_Visible, edtavCamgewshost_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0021.htm");
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
            GxWebStd.gx_div_start( context, divAmgewslocfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgewslocfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgewslocfilter_Internalname, "Location", "", "", lblLblamgewslocfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14091_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0021.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgewsloc_Internalname, "Location", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgewsloc_Internalname, StringUtil.RTrim( AV9cAmgeWsLoc), StringUtil.RTrim( context.localUtil.Format( AV9cAmgeWsLoc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgewsloc_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgewsloc_Visible, edtavCamgewsloc_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0021.htm");
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
            GxWebStd.gx_div_start( context, divAmgewstipfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgewstipfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgewstipfilter_Internalname, "Tipo", "", "", lblLblamgewstipfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15091_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0021.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgewstip_Internalname, "Tipo", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgewstip_Internalname, StringUtil.RTrim( AV10cAmgeWsTip), StringUtil.RTrim( context.localUtil.Format( AV10cAmgeWsTip, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgewstip_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgewstip_Visible, edtavCamgewstip_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0021.htm");
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
            GxWebStd.gx_div_start( context, divAmgewsestfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgewsestfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgewsestfilter_Internalname, "Estado", "", "", lblLblamgewsestfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16091_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0021.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgewsest_Internalname, "Estado", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgewsest_Internalname, StringUtil.RTrim( AV11cAmgeWsEst), StringUtil.RTrim( context.localUtil.Format( AV11cAmgeWsEst, "!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgewsest_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgewsest_Visible, edtavCamgewsest_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0021.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e17091_client"+"'", TempTags, "", 2, "HLP_Gx0021.htm");
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
               context.SendWebValue( "Secuencia") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Puerto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Host") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Location") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A3AmgewsSec));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A21AmgeWsPort), 4, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtAmgeWsPort_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A22AmgeWsHost));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A24AmgeWsLoc));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A25AmgeWsTip));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A26AmgeWsEst));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0021.htm");
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

      protected void START092( )
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
            Form.Meta.addItem("description", "Selection List Detalle de Configuracion WebServices", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP090( ) ;
      }

      protected void WS092( )
      {
         START092( ) ;
         EVT092( ) ;
      }

      protected void EVT092( )
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
                              A3AmgewsSec = cgiGet( edtAmgewsSec_Internalname);
                              A21AmgeWsPort = (short)(context.localUtil.CToN( cgiGet( edtAmgeWsPort_Internalname), ",", "."));
                              A22AmgeWsHost = cgiGet( edtAmgeWsHost_Internalname);
                              A24AmgeWsLoc = cgiGet( edtAmgeWsLoc_Internalname);
                              A25AmgeWsTip = cgiGet( edtAmgeWsTip_Internalname);
                              A26AmgeWsEst = StringUtil.Upper( cgiGet( edtAmgeWsEst_Internalname));
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
                                    E18092 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E19092 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Camgewssec Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEWSSEC"), AV6cAmgewsSec) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgewsport Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAMGEWSPORT"), ",", ".") != Convert.ToDecimal( AV7cAmgeWsPort )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgewshost Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEWSHOST"), AV8cAmgeWsHost) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgewsloc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEWSLOC"), AV9cAmgeWsLoc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgewstip Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEWSTIP"), AV10cAmgeWsTip) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgewsest Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEWSEST"), AV11cAmgeWsEst) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E20092 ();
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

      protected void WE092( )
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

      protected void PA092( )
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
                                        String AV6cAmgewsSec ,
                                        short AV7cAmgeWsPort ,
                                        String AV8cAmgeWsHost ,
                                        String AV9cAmgeWsLoc ,
                                        String AV10cAmgeWsTip ,
                                        String AV11cAmgeWsEst ,
                                        String AV12pAmGecod )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID1_nCurrentRecord = 0;
         RF092( ) ;
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         send_integrity_footer_hashes( ) ;
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_AMGEWSSEC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A3AmgewsSec, "")), context));
         GxWebStd.gx_hidden_field( context, "AMGEWSSEC", StringUtil.RTrim( A3AmgewsSec));
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
         RF092( ) ;
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

      protected void RF092( )
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
                                                 AV7cAmgeWsPort ,
                                                 AV8cAmgeWsHost ,
                                                 AV9cAmgeWsLoc ,
                                                 AV10cAmgeWsTip ,
                                                 AV11cAmgeWsEst ,
                                                 A21AmgeWsPort ,
                                                 A22AmgeWsHost ,
                                                 A24AmgeWsLoc ,
                                                 A25AmgeWsTip ,
                                                 A26AmgeWsEst ,
                                                 A3AmgewsSec ,
                                                 AV6cAmgewsSec ,
                                                 AV12pAmGecod ,
                                                 A1AmGecod } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                                 }
            } ) ;
            lV6cAmgewsSec = StringUtil.PadR( StringUtil.RTrim( AV6cAmgewsSec), 3, "%");
            lV8cAmgeWsHost = StringUtil.PadR( StringUtil.RTrim( AV8cAmgeWsHost), 20, "%");
            lV9cAmgeWsLoc = StringUtil.PadR( StringUtil.RTrim( AV9cAmgeWsLoc), 3, "%");
            lV10cAmgeWsTip = StringUtil.PadR( StringUtil.RTrim( AV10cAmgeWsTip), 3, "%");
            lV11cAmgeWsEst = StringUtil.PadR( StringUtil.RTrim( AV11cAmgeWsEst), 1, "%");
            /* Using cursor H00092 */
            pr_default.execute(0, new Object[] {AV12pAmGecod, lV6cAmgewsSec, AV7cAmgeWsPort, lV8cAmgeWsHost, lV9cAmgeWsLoc, lV10cAmgeWsTip, lV11cAmgeWsEst, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_74_idx = 1;
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
            SubsflControlProps_742( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( GRID1_nCurrentRecord < subGrid1_fnc_Recordsperpage( ) ) ) )
            {
               A1AmGecod = H00092_A1AmGecod[0];
               A26AmgeWsEst = H00092_A26AmgeWsEst[0];
               A25AmgeWsTip = H00092_A25AmgeWsTip[0];
               A24AmgeWsLoc = H00092_A24AmgeWsLoc[0];
               A22AmgeWsHost = H00092_A22AmgeWsHost[0];
               A21AmgeWsPort = H00092_A21AmgeWsPort[0];
               A3AmgewsSec = H00092_A3AmgewsSec[0];
               /* Execute user event: Load */
               E19092 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB090( ) ;
         }
         bGXsfl_74_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes092( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_AMGEWSSEC"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, StringUtil.RTrim( context.localUtil.Format( A3AmgewsSec, "")), context));
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
                                              AV7cAmgeWsPort ,
                                              AV8cAmgeWsHost ,
                                              AV9cAmgeWsLoc ,
                                              AV10cAmgeWsTip ,
                                              AV11cAmgeWsEst ,
                                              A21AmgeWsPort ,
                                              A22AmgeWsHost ,
                                              A24AmgeWsLoc ,
                                              A25AmgeWsTip ,
                                              A26AmgeWsEst ,
                                              A3AmgewsSec ,
                                              AV6cAmgewsSec ,
                                              AV12pAmGecod ,
                                              A1AmGecod } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV6cAmgewsSec = StringUtil.PadR( StringUtil.RTrim( AV6cAmgewsSec), 3, "%");
         lV8cAmgeWsHost = StringUtil.PadR( StringUtil.RTrim( AV8cAmgeWsHost), 20, "%");
         lV9cAmgeWsLoc = StringUtil.PadR( StringUtil.RTrim( AV9cAmgeWsLoc), 3, "%");
         lV10cAmgeWsTip = StringUtil.PadR( StringUtil.RTrim( AV10cAmgeWsTip), 3, "%");
         lV11cAmgeWsEst = StringUtil.PadR( StringUtil.RTrim( AV11cAmgeWsEst), 1, "%");
         /* Using cursor H00093 */
         pr_default.execute(1, new Object[] {AV12pAmGecod, lV6cAmgewsSec, AV7cAmgeWsPort, lV8cAmgeWsHost, lV9cAmgeWsLoc, lV10cAmgeWsTip, lV11cAmgeWsEst});
         GRID1_nRecordCount = H00093_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmgewsSec, AV7cAmgeWsPort, AV8cAmgeWsHost, AV9cAmgeWsLoc, AV10cAmgeWsTip, AV11cAmgeWsEst, AV12pAmGecod) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmgewsSec, AV7cAmgeWsPort, AV8cAmgeWsHost, AV9cAmgeWsLoc, AV10cAmgeWsTip, AV11cAmgeWsEst, AV12pAmGecod) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmgewsSec, AV7cAmgeWsPort, AV8cAmgeWsHost, AV9cAmgeWsLoc, AV10cAmgeWsTip, AV11cAmgeWsEst, AV12pAmGecod) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmgewsSec, AV7cAmgeWsPort, AV8cAmgeWsHost, AV9cAmgeWsLoc, AV10cAmgeWsTip, AV11cAmgeWsEst, AV12pAmGecod) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmgewsSec, AV7cAmgeWsPort, AV8cAmgeWsHost, AV9cAmgeWsLoc, AV10cAmgeWsTip, AV11cAmgeWsEst, AV12pAmGecod) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void before_start_formulas( )
      {
         context.Gx_err = 0;
      }

      protected void STRUP090( )
      {
         /* Before Start, stand alone formulas. */
         before_start_formulas( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E18092 ();
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
            AV6cAmgewsSec = cgiGet( edtavCamgewssec_Internalname);
            AssignAttri("", false, "AV6cAmgewsSec", AV6cAmgewsSec);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCamgewsport_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCamgewsport_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCAMGEWSPORT");
               GX_FocusControl = edtavCamgewsport_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cAmgeWsPort = 0;
               AssignAttri("", false, "AV7cAmgeWsPort", StringUtil.LTrimStr( (decimal)(AV7cAmgeWsPort), 4, 0));
            }
            else
            {
               AV7cAmgeWsPort = (short)(context.localUtil.CToN( cgiGet( edtavCamgewsport_Internalname), ",", "."));
               AssignAttri("", false, "AV7cAmgeWsPort", StringUtil.LTrimStr( (decimal)(AV7cAmgeWsPort), 4, 0));
            }
            AV8cAmgeWsHost = cgiGet( edtavCamgewshost_Internalname);
            AssignAttri("", false, "AV8cAmgeWsHost", AV8cAmgeWsHost);
            AV9cAmgeWsLoc = cgiGet( edtavCamgewsloc_Internalname);
            AssignAttri("", false, "AV9cAmgeWsLoc", AV9cAmgeWsLoc);
            AV10cAmgeWsTip = cgiGet( edtavCamgewstip_Internalname);
            AssignAttri("", false, "AV10cAmgeWsTip", AV10cAmgeWsTip);
            AV11cAmgeWsEst = StringUtil.Upper( cgiGet( edtavCamgewsest_Internalname));
            AssignAttri("", false, "AV11cAmgeWsEst", AV11cAmgeWsEst);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEWSSEC"), AV6cAmgewsSec) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAMGEWSPORT"), ",", ".") != Convert.ToDecimal( AV7cAmgeWsPort )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEWSHOST"), AV8cAmgeWsHost) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEWSLOC"), AV9cAmgeWsLoc) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEWSTIP"), AV10cAmgeWsTip) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEWSEST"), AV11cAmgeWsEst) != 0 )
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
         E18092 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E18092( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Detalle de Configuracion WebServices", "", "", "", "", "", "", "", "");
         AssignProp("", false, "FORM", "Caption", Form.Caption, true);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E19092( )
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
         E20092 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E20092( )
      {
         /* Enter Routine */
         AV13pAmgewsSec = A3AmgewsSec;
         AssignAttri("", false, "AV13pAmgewsSec", AV13pAmgewsSec);
         context.setWebReturnParms(new Object[] {(String)AV13pAmgewsSec});
         context.setWebReturnParmsMetadata(new Object[] {"AV13pAmgewsSec"});
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
         AV13pAmgewsSec = (String)getParm(obj,1);
         AssignAttri("", false, "AV13pAmgewsSec", AV13pAmgewsSec);
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
         PA092( ) ;
         WS092( ) ;
         WE092( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202242110263359", true, true);
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
         context.AddJavascriptSource("gx0021.js", "?202242110263359", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtAmgewsSec_Internalname = "AMGEWSSEC_"+sGXsfl_74_idx;
         edtAmgeWsPort_Internalname = "AMGEWSPORT_"+sGXsfl_74_idx;
         edtAmgeWsHost_Internalname = "AMGEWSHOST_"+sGXsfl_74_idx;
         edtAmgeWsLoc_Internalname = "AMGEWSLOC_"+sGXsfl_74_idx;
         edtAmgeWsTip_Internalname = "AMGEWSTIP_"+sGXsfl_74_idx;
         edtAmgeWsEst_Internalname = "AMGEWSEST_"+sGXsfl_74_idx;
         edtAmGecod_Internalname = "AMGECOD_"+sGXsfl_74_idx;
      }

      protected void SubsflControlProps_fel_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_fel_idx;
         edtAmgewsSec_Internalname = "AMGEWSSEC_"+sGXsfl_74_fel_idx;
         edtAmgeWsPort_Internalname = "AMGEWSPORT_"+sGXsfl_74_fel_idx;
         edtAmgeWsHost_Internalname = "AMGEWSHOST_"+sGXsfl_74_fel_idx;
         edtAmgeWsLoc_Internalname = "AMGEWSLOC_"+sGXsfl_74_fel_idx;
         edtAmgeWsTip_Internalname = "AMGEWSTIP_"+sGXsfl_74_fel_idx;
         edtAmgeWsEst_Internalname = "AMGEWSEST_"+sGXsfl_74_fel_idx;
         edtAmGecod_Internalname = "AMGECOD_"+sGXsfl_74_fel_idx;
      }

      protected void sendrow_742( )
      {
         SubsflControlProps_742( ) ;
         WB090( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A3AmgewsSec))+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgewsSec_Internalname,StringUtil.RTrim( A3AmgewsSec),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgewsSec_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtAmgeWsPort_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A3AmgewsSec))+"'"+"]);";
            AssignProp("", false, edtAmgeWsPort_Internalname, "Link", edtAmgeWsPort_Link, !bGXsfl_74_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeWsPort_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A21AmgeWsPort), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A21AmgeWsPort), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtAmgeWsPort_Link,(String)"",(String)"",(String)"",(String)edtAmgeWsPort_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeWsHost_Internalname,StringUtil.RTrim( A22AmgeWsHost),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeWsHost_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeWsLoc_Internalname,StringUtil.RTrim( A24AmgeWsLoc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeWsLoc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeWsTip_Internalname,StringUtil.RTrim( A25AmgeWsTip),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeWsTip_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeWsEst_Internalname,StringUtil.RTrim( A26AmgeWsEst),StringUtil.RTrim( context.localUtil.Format( A26AmgeWsEst, "!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeWsEst_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"Calificacion",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGecod_Internalname,StringUtil.RTrim( A1AmGecod),StringUtil.RTrim( context.localUtil.Format( A1AmGecod, "99999")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmGecod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"codmediano",(String)"left",(bool)true,(String)""});
            send_integrity_lvl_hashes092( ) ;
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
         lblLblamgewssecfilter_Internalname = "LBLAMGEWSSECFILTER";
         edtavCamgewssec_Internalname = "vCAMGEWSSEC";
         divAmgewssecfiltercontainer_Internalname = "AMGEWSSECFILTERCONTAINER";
         lblLblamgewsportfilter_Internalname = "LBLAMGEWSPORTFILTER";
         edtavCamgewsport_Internalname = "vCAMGEWSPORT";
         divAmgewsportfiltercontainer_Internalname = "AMGEWSPORTFILTERCONTAINER";
         lblLblamgewshostfilter_Internalname = "LBLAMGEWSHOSTFILTER";
         edtavCamgewshost_Internalname = "vCAMGEWSHOST";
         divAmgewshostfiltercontainer_Internalname = "AMGEWSHOSTFILTERCONTAINER";
         lblLblamgewslocfilter_Internalname = "LBLAMGEWSLOCFILTER";
         edtavCamgewsloc_Internalname = "vCAMGEWSLOC";
         divAmgewslocfiltercontainer_Internalname = "AMGEWSLOCFILTERCONTAINER";
         lblLblamgewstipfilter_Internalname = "LBLAMGEWSTIPFILTER";
         edtavCamgewstip_Internalname = "vCAMGEWSTIP";
         divAmgewstipfiltercontainer_Internalname = "AMGEWSTIPFILTERCONTAINER";
         lblLblamgewsestfilter_Internalname = "LBLAMGEWSESTFILTER";
         edtavCamgewsest_Internalname = "vCAMGEWSEST";
         divAmgewsestfiltercontainer_Internalname = "AMGEWSESTFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtAmgewsSec_Internalname = "AMGEWSSEC";
         edtAmgeWsPort_Internalname = "AMGEWSPORT";
         edtAmgeWsHost_Internalname = "AMGEWSHOST";
         edtAmgeWsLoc_Internalname = "AMGEWSLOC";
         edtAmgeWsTip_Internalname = "AMGEWSTIP";
         edtAmgeWsEst_Internalname = "AMGEWSEST";
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
         edtAmgeWsEst_Jsonclick = "";
         edtAmgeWsTip_Jsonclick = "";
         edtAmgeWsLoc_Jsonclick = "";
         edtAmgeWsHost_Jsonclick = "";
         edtAmgeWsPort_Jsonclick = "";
         edtAmgewsSec_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtAmgeWsPort_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCamgewsest_Jsonclick = "";
         edtavCamgewsest_Enabled = 1;
         edtavCamgewsest_Visible = 1;
         edtavCamgewstip_Jsonclick = "";
         edtavCamgewstip_Enabled = 1;
         edtavCamgewstip_Visible = 1;
         edtavCamgewsloc_Jsonclick = "";
         edtavCamgewsloc_Enabled = 1;
         edtavCamgewsloc_Visible = 1;
         edtavCamgewshost_Jsonclick = "";
         edtavCamgewshost_Enabled = 1;
         edtavCamgewshost_Visible = 1;
         edtavCamgewsport_Jsonclick = "";
         edtavCamgewsport_Enabled = 1;
         edtavCamgewsport_Visible = 1;
         edtavCamgewssec_Jsonclick = "";
         edtavCamgewssec_Enabled = 1;
         edtavCamgewssec_Visible = 1;
         divAmgewsestfiltercontainer_Class = "AdvancedContainerItem";
         divAmgewstipfiltercontainer_Class = "AdvancedContainerItem";
         divAmgewslocfiltercontainer_Class = "AdvancedContainerItem";
         divAmgewshostfiltercontainer_Class = "AdvancedContainerItem";
         divAmgewsportfiltercontainer_Class = "AdvancedContainerItem";
         divAmgewssecfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Detalle de Configuracion WebServices";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmgewsSec',fld:'vCAMGEWSSEC',pic:''},{av:'AV7cAmgeWsPort',fld:'vCAMGEWSPORT',pic:'ZZZ9'},{av:'AV8cAmgeWsHost',fld:'vCAMGEWSHOST',pic:''},{av:'AV9cAmgeWsLoc',fld:'vCAMGEWSLOC',pic:''},{av:'AV10cAmgeWsTip',fld:'vCAMGEWSTIP',pic:''},{av:'AV11cAmgeWsEst',fld:'vCAMGEWSEST',pic:'!'},{av:'AV12pAmGecod',fld:'vPAMGECOD',pic:'99999'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E17091',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLAMGEWSSECFILTER.CLICK","{handler:'E11091',iparms:[{av:'divAmgewssecfiltercontainer_Class',ctrl:'AMGEWSSECFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEWSSECFILTER.CLICK",",oparms:[{av:'divAmgewssecfiltercontainer_Class',ctrl:'AMGEWSSECFILTERCONTAINER',prop:'Class'},{av:'edtavCamgewssec_Visible',ctrl:'vCAMGEWSSEC',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEWSPORTFILTER.CLICK","{handler:'E12091',iparms:[{av:'divAmgewsportfiltercontainer_Class',ctrl:'AMGEWSPORTFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEWSPORTFILTER.CLICK",",oparms:[{av:'divAmgewsportfiltercontainer_Class',ctrl:'AMGEWSPORTFILTERCONTAINER',prop:'Class'},{av:'edtavCamgewsport_Visible',ctrl:'vCAMGEWSPORT',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEWSHOSTFILTER.CLICK","{handler:'E13091',iparms:[{av:'divAmgewshostfiltercontainer_Class',ctrl:'AMGEWSHOSTFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEWSHOSTFILTER.CLICK",",oparms:[{av:'divAmgewshostfiltercontainer_Class',ctrl:'AMGEWSHOSTFILTERCONTAINER',prop:'Class'},{av:'edtavCamgewshost_Visible',ctrl:'vCAMGEWSHOST',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEWSLOCFILTER.CLICK","{handler:'E14091',iparms:[{av:'divAmgewslocfiltercontainer_Class',ctrl:'AMGEWSLOCFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEWSLOCFILTER.CLICK",",oparms:[{av:'divAmgewslocfiltercontainer_Class',ctrl:'AMGEWSLOCFILTERCONTAINER',prop:'Class'},{av:'edtavCamgewsloc_Visible',ctrl:'vCAMGEWSLOC',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEWSTIPFILTER.CLICK","{handler:'E15091',iparms:[{av:'divAmgewstipfiltercontainer_Class',ctrl:'AMGEWSTIPFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEWSTIPFILTER.CLICK",",oparms:[{av:'divAmgewstipfiltercontainer_Class',ctrl:'AMGEWSTIPFILTERCONTAINER',prop:'Class'},{av:'edtavCamgewstip_Visible',ctrl:'vCAMGEWSTIP',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEWSESTFILTER.CLICK","{handler:'E16091',iparms:[{av:'divAmgewsestfiltercontainer_Class',ctrl:'AMGEWSESTFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEWSESTFILTER.CLICK",",oparms:[{av:'divAmgewsestfiltercontainer_Class',ctrl:'AMGEWSESTFILTERCONTAINER',prop:'Class'},{av:'edtavCamgewsest_Visible',ctrl:'vCAMGEWSEST',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E20092',iparms:[{av:'A3AmgewsSec',fld:'AMGEWSSEC',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV13pAmgewsSec',fld:'vPAMGEWSSEC',pic:''}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmgewsSec',fld:'vCAMGEWSSEC',pic:''},{av:'AV7cAmgeWsPort',fld:'vCAMGEWSPORT',pic:'ZZZ9'},{av:'AV8cAmgeWsHost',fld:'vCAMGEWSHOST',pic:''},{av:'AV9cAmgeWsLoc',fld:'vCAMGEWSLOC',pic:''},{av:'AV10cAmgeWsTip',fld:'vCAMGEWSTIP',pic:''},{av:'AV11cAmgeWsEst',fld:'vCAMGEWSEST',pic:'!'},{av:'AV12pAmGecod',fld:'vPAMGECOD',pic:'99999'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmgewsSec',fld:'vCAMGEWSSEC',pic:''},{av:'AV7cAmgeWsPort',fld:'vCAMGEWSPORT',pic:'ZZZ9'},{av:'AV8cAmgeWsHost',fld:'vCAMGEWSHOST',pic:''},{av:'AV9cAmgeWsLoc',fld:'vCAMGEWSLOC',pic:''},{av:'AV10cAmgeWsTip',fld:'vCAMGEWSTIP',pic:''},{av:'AV11cAmgeWsEst',fld:'vCAMGEWSEST',pic:'!'},{av:'AV12pAmGecod',fld:'vPAMGECOD',pic:'99999'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmgewsSec',fld:'vCAMGEWSSEC',pic:''},{av:'AV7cAmgeWsPort',fld:'vCAMGEWSPORT',pic:'ZZZ9'},{av:'AV8cAmgeWsHost',fld:'vCAMGEWSHOST',pic:''},{av:'AV9cAmgeWsLoc',fld:'vCAMGEWSLOC',pic:''},{av:'AV10cAmgeWsTip',fld:'vCAMGEWSTIP',pic:''},{av:'AV11cAmgeWsEst',fld:'vCAMGEWSEST',pic:'!'},{av:'AV12pAmGecod',fld:'vPAMGECOD',pic:'99999'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmgewsSec',fld:'vCAMGEWSSEC',pic:''},{av:'AV7cAmgeWsPort',fld:'vCAMGEWSPORT',pic:'ZZZ9'},{av:'AV8cAmgeWsHost',fld:'vCAMGEWSHOST',pic:''},{av:'AV9cAmgeWsLoc',fld:'vCAMGEWSLOC',pic:''},{av:'AV10cAmgeWsTip',fld:'vCAMGEWSTIP',pic:''},{av:'AV11cAmgeWsEst',fld:'vCAMGEWSEST',pic:'!'},{av:'AV12pAmGecod',fld:'vPAMGECOD',pic:'99999'}]");
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
         AV6cAmgewsSec = "";
         AV8cAmgeWsHost = "";
         AV9cAmgeWsLoc = "";
         AV10cAmgeWsTip = "";
         AV11cAmgeWsEst = "";
         AV13pAmgewsSec = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblamgewssecfilter_Jsonclick = "";
         TempTags = "";
         lblLblamgewsportfilter_Jsonclick = "";
         lblLblamgewshostfilter_Jsonclick = "";
         lblLblamgewslocfilter_Jsonclick = "";
         lblLblamgewstipfilter_Jsonclick = "";
         lblLblamgewsestfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A3AmgewsSec = "";
         A22AmgeWsHost = "";
         A24AmgeWsLoc = "";
         A25AmgeWsTip = "";
         A26AmgeWsEst = "";
         A1AmGecod = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         scmdbuf = "";
         lV6cAmgewsSec = "";
         lV8cAmgeWsHost = "";
         lV9cAmgeWsLoc = "";
         lV10cAmgeWsTip = "";
         lV11cAmgeWsEst = "";
         H00092_A1AmGecod = new String[] {""} ;
         H00092_A26AmgeWsEst = new String[] {""} ;
         H00092_A25AmgeWsTip = new String[] {""} ;
         H00092_A24AmgeWsLoc = new String[] {""} ;
         H00092_A22AmgeWsHost = new String[] {""} ;
         H00092_A21AmgeWsPort = new short[1] ;
         H00092_A3AmgewsSec = new String[] {""} ;
         H00093_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0021__default(),
            new Object[][] {
                new Object[] {
               H00092_A1AmGecod, H00092_A26AmgeWsEst, H00092_A25AmgeWsTip, H00092_A24AmgeWsLoc, H00092_A22AmgeWsHost, H00092_A21AmgeWsPort, H00092_A3AmgewsSec
               }
               , new Object[] {
               H00093_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short GRID1_nEOF ;
      private short nGotPars ;
      private short GxWebError ;
      private short AV7cAmgeWsPort ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A21AmgeWsPort ;
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
      private int edtavCamgewssec_Visible ;
      private int edtavCamgewssec_Enabled ;
      private int edtavCamgewsport_Enabled ;
      private int edtavCamgewsport_Visible ;
      private int edtavCamgewshost_Visible ;
      private int edtavCamgewshost_Enabled ;
      private int edtavCamgewsloc_Visible ;
      private int edtavCamgewsloc_Enabled ;
      private int edtavCamgewstip_Visible ;
      private int edtavCamgewstip_Enabled ;
      private int edtavCamgewsest_Visible ;
      private int edtavCamgewsest_Enabled ;
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
      private String divAmgewssecfiltercontainer_Class ;
      private String divAmgewsportfiltercontainer_Class ;
      private String divAmgewshostfiltercontainer_Class ;
      private String divAmgewslocfiltercontainer_Class ;
      private String divAmgewstipfiltercontainer_Class ;
      private String divAmgewsestfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_74_idx="0001" ;
      private String AV6cAmgewsSec ;
      private String AV8cAmgeWsHost ;
      private String AV9cAmgeWsLoc ;
      private String AV10cAmgeWsTip ;
      private String AV11cAmgeWsEst ;
      private String AV13pAmgewsSec ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divAmgewssecfiltercontainer_Internalname ;
      private String lblLblamgewssecfilter_Internalname ;
      private String lblLblamgewssecfilter_Jsonclick ;
      private String edtavCamgewssec_Internalname ;
      private String TempTags ;
      private String edtavCamgewssec_Jsonclick ;
      private String divAmgewsportfiltercontainer_Internalname ;
      private String lblLblamgewsportfilter_Internalname ;
      private String lblLblamgewsportfilter_Jsonclick ;
      private String edtavCamgewsport_Internalname ;
      private String edtavCamgewsport_Jsonclick ;
      private String divAmgewshostfiltercontainer_Internalname ;
      private String lblLblamgewshostfilter_Internalname ;
      private String lblLblamgewshostfilter_Jsonclick ;
      private String edtavCamgewshost_Internalname ;
      private String edtavCamgewshost_Jsonclick ;
      private String divAmgewslocfiltercontainer_Internalname ;
      private String lblLblamgewslocfilter_Internalname ;
      private String lblLblamgewslocfilter_Jsonclick ;
      private String edtavCamgewsloc_Internalname ;
      private String edtavCamgewsloc_Jsonclick ;
      private String divAmgewstipfiltercontainer_Internalname ;
      private String lblLblamgewstipfilter_Internalname ;
      private String lblLblamgewstipfilter_Jsonclick ;
      private String edtavCamgewstip_Internalname ;
      private String edtavCamgewstip_Jsonclick ;
      private String divAmgewsestfiltercontainer_Internalname ;
      private String lblLblamgewsestfilter_Internalname ;
      private String lblLblamgewsestfilter_Jsonclick ;
      private String edtavCamgewsest_Internalname ;
      private String edtavCamgewsest_Jsonclick ;
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
      private String A3AmgewsSec ;
      private String edtAmgeWsPort_Link ;
      private String A22AmgeWsHost ;
      private String A24AmgeWsLoc ;
      private String A25AmgeWsTip ;
      private String A26AmgeWsEst ;
      private String A1AmGecod ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtAmgewsSec_Internalname ;
      private String edtAmgeWsPort_Internalname ;
      private String edtAmgeWsHost_Internalname ;
      private String edtAmgeWsLoc_Internalname ;
      private String edtAmgeWsTip_Internalname ;
      private String edtAmgeWsEst_Internalname ;
      private String edtAmGecod_Internalname ;
      private String scmdbuf ;
      private String lV6cAmgewsSec ;
      private String lV8cAmgeWsHost ;
      private String lV9cAmgeWsLoc ;
      private String lV10cAmgeWsTip ;
      private String lV11cAmgeWsEst ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_74_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtAmgewsSec_Jsonclick ;
      private String edtAmgeWsPort_Jsonclick ;
      private String edtAmgeWsHost_Jsonclick ;
      private String edtAmgeWsLoc_Jsonclick ;
      private String edtAmgeWsTip_Jsonclick ;
      private String edtAmgeWsEst_Jsonclick ;
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
      private String AV17Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsSistema ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00092_A1AmGecod ;
      private String[] H00092_A26AmgeWsEst ;
      private String[] H00092_A25AmgeWsTip ;
      private String[] H00092_A24AmgeWsLoc ;
      private String[] H00092_A22AmgeWsHost ;
      private short[] H00092_A21AmgeWsPort ;
      private String[] H00092_A3AmgewsSec ;
      private long[] H00093_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP1_pAmgewsSec ;
      private GXWebForm Form ;
   }

   public class gx0021__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00092( IGxContext context ,
                                             short AV7cAmgeWsPort ,
                                             String AV8cAmgeWsHost ,
                                             String AV9cAmgeWsLoc ,
                                             String AV10cAmgeWsTip ,
                                             String AV11cAmgeWsEst ,
                                             short A21AmgeWsPort ,
                                             String A22AmgeWsHost ,
                                             String A24AmgeWsLoc ,
                                             String A25AmgeWsTip ,
                                             String A26AmgeWsEst ,
                                             String A3AmgewsSec ,
                                             String AV6cAmgewsSec ,
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
         sSelectString = " [AmGecod], [AmgeWsEst], [AmgeWsTip], [AmgeWsLoc], [AmgeWsHost], [AmgeWsPort], [AmgewsSec]";
         sFromString = " FROM [AgAmGe3]";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([AmGecod] = @AV12pAmGecod)";
         sWhereString = sWhereString + " and ([AmgewsSec] like @lV6cAmgewsSec)";
         if ( ! (0==AV7cAmgeWsPort) )
         {
            sWhereString = sWhereString + " and ([AmgeWsPort] >= @AV7cAmgeWsPort)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cAmgeWsHost)) )
         {
            sWhereString = sWhereString + " and ([AmgeWsHost] like @lV8cAmgeWsHost)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cAmgeWsLoc)) )
         {
            sWhereString = sWhereString + " and ([AmgeWsLoc] like @lV9cAmgeWsLoc)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cAmgeWsTip)) )
         {
            sWhereString = sWhereString + " and ([AmgeWsTip] like @lV10cAmgeWsTip)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cAmgeWsEst)) )
         {
            sWhereString = sWhereString + " and ([AmgeWsEst] like @lV11cAmgeWsEst)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [AmGecod], [AmgewsSec]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + sOrderString + "" + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00093( IGxContext context ,
                                             short AV7cAmgeWsPort ,
                                             String AV8cAmgeWsHost ,
                                             String AV9cAmgeWsLoc ,
                                             String AV10cAmgeWsTip ,
                                             String AV11cAmgeWsEst ,
                                             short A21AmgeWsPort ,
                                             String A22AmgeWsHost ,
                                             String A24AmgeWsLoc ,
                                             String A25AmgeWsTip ,
                                             String A26AmgeWsEst ,
                                             String A3AmgewsSec ,
                                             String AV6cAmgewsSec ,
                                             String AV12pAmGecod ,
                                             String A1AmGecod )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [AgAmGe3]";
         scmdbuf = scmdbuf + " WHERE ([AmGecod] = @AV12pAmGecod)";
         scmdbuf = scmdbuf + " and ([AmgewsSec] like @lV6cAmgewsSec)";
         if ( ! (0==AV7cAmgeWsPort) )
         {
            sWhereString = sWhereString + " and ([AmgeWsPort] >= @AV7cAmgeWsPort)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cAmgeWsHost)) )
         {
            sWhereString = sWhereString + " and ([AmgeWsHost] like @lV8cAmgeWsHost)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cAmgeWsLoc)) )
         {
            sWhereString = sWhereString + " and ([AmgeWsLoc] like @lV9cAmgeWsLoc)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cAmgeWsTip)) )
         {
            sWhereString = sWhereString + " and ([AmgeWsTip] like @lV10cAmgeWsTip)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cAmgeWsEst)) )
         {
            sWhereString = sWhereString + " and ([AmgeWsEst] like @lV11cAmgeWsEst)";
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
                     return conditional_H00092(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] );
               case 1 :
                     return conditional_H00093(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] );
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
          Object[] prmH00092 ;
          prmH00092 = new Object[] {
          new Object[] {"@AV12pAmGecod",SqlDbType.NChar,5,0} ,
          new Object[] {"@lV6cAmgewsSec",SqlDbType.NChar,3,0} ,
          new Object[] {"@AV7cAmgeWsPort",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV8cAmgeWsHost",SqlDbType.NChar,20,0} ,
          new Object[] {"@lV9cAmgeWsLoc",SqlDbType.NChar,3,0} ,
          new Object[] {"@lV10cAmgeWsTip",SqlDbType.NChar,3,0} ,
          new Object[] {"@lV11cAmgeWsEst",SqlDbType.NChar,1,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00093 ;
          prmH00093 = new Object[] {
          new Object[] {"@AV12pAmGecod",SqlDbType.NChar,5,0} ,
          new Object[] {"@lV6cAmgewsSec",SqlDbType.NChar,3,0} ,
          new Object[] {"@AV7cAmgeWsPort",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV8cAmgeWsHost",SqlDbType.NChar,20,0} ,
          new Object[] {"@lV9cAmgeWsLoc",SqlDbType.NChar,3,0} ,
          new Object[] {"@lV10cAmgeWsTip",SqlDbType.NChar,3,0} ,
          new Object[] {"@lV11cAmgeWsEst",SqlDbType.NChar,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00092", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00092,11, GxCacheFrequency.OFF ,false,false )
             ,new CursorDef("H00093", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00093,1, GxCacheFrequency.OFF ,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 3) ;
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
