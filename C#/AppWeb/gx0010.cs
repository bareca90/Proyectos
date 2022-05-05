/*
               File: Gx0010
        Description: Selection List Ambiente General
             Author: GeneXus C# Generator version 16_0_11-144151
       Generated on: 4/21/2022 10:26:31.23
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
   public class gx0010 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0010( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsSistema = context.GetDataStore("Sistema");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx0010( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsSistema = context.GetDataStore("Sistema");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pAmGecod )
      {
         this.AV13pAmGecod = "" ;
         executePrivate();
         aP0_pAmGecod=this.AV13pAmGecod;
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
               nRC_GXsfl_84 = (int)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_84_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_84_idx = GetNextPar( );
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
               AV6cAmGecod = GetNextPar( );
               AV7cAmGedes = GetNextPar( );
               AV8cAmGeval = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV9cAmGedet = GetNextPar( );
               AV10cAmgeAbr = GetNextPar( );
               AV11cAmGesta = GetNextPar( );
               AV12cAmgeAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cAmGecod, AV7cAmGedes, AV8cAmGeval, AV9cAmGedet, AV10cAmgeAbr, AV11cAmGesta, AV12cAmgeAnio) ;
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
               AV13pAmGecod = gxfirstwebparm;
               AssignAttri("", false, "AV13pAmGecod", AV13pAmGecod);
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
         PA082( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START082( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202242110263132", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0010.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pAmGecod))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGECOD", StringUtil.RTrim( AV6cAmGecod));
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEDES", StringUtil.RTrim( AV7cAmGedes));
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEVAL", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cAmGeval), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEDET", StringUtil.RTrim( AV9cAmGedet));
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEABR", StringUtil.RTrim( AV10cAmgeAbr));
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGESTA", StringUtil.RTrim( AV11cAmGesta));
         GxWebStd.gx_hidden_field( context, "GXH_vCAMGEANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cAmgeAnio), 4, 0, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPAMGECOD", StringUtil.RTrim( AV13pAmGecod));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "AMGECODFILTERCONTAINER_Class", StringUtil.RTrim( divAmgecodfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEDESFILTERCONTAINER_Class", StringUtil.RTrim( divAmgedesfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEVALFILTERCONTAINER_Class", StringUtil.RTrim( divAmgevalfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEDETFILTERCONTAINER_Class", StringUtil.RTrim( divAmgedetfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEABRFILTERCONTAINER_Class", StringUtil.RTrim( divAmgeabrfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGESTAFILTERCONTAINER_Class", StringUtil.RTrim( divAmgestafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AMGEANIOFILTERCONTAINER_Class", StringUtil.RTrim( divAmgeaniofiltercontainer_Class));
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
            WE082( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT082( ) ;
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
         return formatLink("gx0010.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pAmGecod)) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0010" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Ambiente General" ;
      }

      protected void WB080( )
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
            GxWebStd.gx_div_start( context, divAmgecodfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgecodfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgecodfilter_Internalname, "Codigo:", "", "", lblLblamgecodfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11081_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgecod_Internalname, "Codigo:", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgecod_Internalname, StringUtil.RTrim( AV6cAmGecod), StringUtil.RTrim( context.localUtil.Format( AV6cAmGecod, "99999")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgecod_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgecod_Visible, edtavCamgecod_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divAmgedesfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgedesfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgedesfilter_Internalname, "Descripción:", "", "", lblLblamgedesfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12081_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgedes_Internalname, "Descripción:", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgedes_Internalname, StringUtil.RTrim( AV7cAmGedes), StringUtil.RTrim( context.localUtil.Format( AV7cAmGedes, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgedes_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgedes_Visible, edtavCamgedes_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divAmgevalfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgevalfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgevalfilter_Internalname, "Valor:", "", "", lblLblamgevalfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13081_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgeval_Internalname, "Valor:", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgeval_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cAmGeval), 13, 0, ",", "")), ((edtavCamgeval_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cAmGeval), "Z,ZZZ,ZZZ,ZZ9")) : context.localUtil.Format( (decimal)(AV8cAmGeval), "Z,ZZZ,ZZZ,ZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgeval_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgeval_Visible, edtavCamgeval_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divAmgedetfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgedetfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgedetfilter_Internalname, "Detalle:", "", "", lblLblamgedetfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14081_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgedet_Internalname, "Detalle:", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgedet_Internalname, StringUtil.RTrim( AV9cAmGedet), StringUtil.RTrim( context.localUtil.Format( AV9cAmGedet, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgedet_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgedet_Visible, edtavCamgedet_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divAmgeabrfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgeabrfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgeabrfilter_Internalname, "Abreviatura", "", "", lblLblamgeabrfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15081_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgeabr_Internalname, "Abreviatura", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgeabr_Internalname, StringUtil.RTrim( AV10cAmgeAbr), StringUtil.RTrim( context.localUtil.Format( AV10cAmgeAbr, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgeabr_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgeabr_Visible, edtavCamgeabr_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divAmgestafiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgestafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgestafilter_Internalname, "Estado:", "", "", lblLblamgestafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16081_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgesta_Internalname, "Estado:", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgesta_Internalname, StringUtil.RTrim( AV11cAmGesta), StringUtil.RTrim( context.localUtil.Format( AV11cAmGesta, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgesta_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgesta_Visible, edtavCamgesta_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divAmgeaniofiltercontainer_Internalname, 1, 0, "px", 0, "px", divAmgeaniofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblamgeaniofilter_Internalname, "Año_", "", "", lblLblamgeaniofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e17081_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCamgeanio_Internalname, "Año_", "col-sm-3 AttributeLabel", 0, true, "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCamgeanio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cAmgeAnio), 4, 0, ",", "")), ((edtavCamgeanio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12cAmgeAnio), "9999")) : context.localUtil.Format( (decimal)(AV12cAmgeAnio), "9999")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCamgeanio_Jsonclick, 0, "Attribute", "", "", "", "", edtavCamgeanio_Visible, edtavCamgeanio_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0010.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e18081_client"+"'", TempTags, "", 2, "HLP_Gx0010.htm");
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"84\">") ;
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
               context.SendWebValue( "Codigo:") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Descripción:") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Valor:") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Detalle:") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Abreviatura") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Estado:") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Año_") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A1AmGecod));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A7AmGedes));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtAmGedes_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11AmGeval), 13, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A12AmGedet));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A20AmgeAbr));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A8AmGesta));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A14AmgeAnio), 4, 0, ".", "")));
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
         if ( wbEnd == 84 )
         {
            wbEnd = 0;
            nRC_GXsfl_84 = (int)(nGXsfl_84_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 84 )
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

      protected void START082( )
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
            Form.Meta.addItem("description", "Selection List Ambiente General", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP080( ) ;
      }

      protected void WS082( )
      {
         START082( ) ;
         EVT082( ) ;
      }

      protected void EVT082( )
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
                              nGXsfl_84_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_84_idx), 4, 0), 4, "0");
                              SubsflControlProps_842( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              AssignProp("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_84_Refreshing);
                              AssignProp("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A1AmGecod = cgiGet( edtAmGecod_Internalname);
                              A7AmGedes = StringUtil.Upper( cgiGet( edtAmGedes_Internalname));
                              n7AmGedes = false;
                              A11AmGeval = (long)(context.localUtil.CToN( cgiGet( edtAmGeval_Internalname), ",", "."));
                              n11AmGeval = false;
                              A12AmGedet = StringUtil.Upper( cgiGet( edtAmGedet_Internalname));
                              n12AmGedet = false;
                              A20AmgeAbr = cgiGet( edtAmgeAbr_Internalname);
                              n20AmgeAbr = false;
                              A8AmGesta = cgiGet( edtAmGesta_Internalname);
                              n8AmGesta = false;
                              A14AmgeAnio = (short)(context.localUtil.CToN( cgiGet( edtAmgeAnio_Internalname), ",", "."));
                              n14AmgeAnio = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E19082 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E20082 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Camgecod Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGECOD"), AV6cAmGecod) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgedes Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEDES"), AV7cAmGedes) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgeval Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAMGEVAL"), ",", ".") != Convert.ToDecimal( AV8cAmGeval )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgedet Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEDET"), AV9cAmGedet) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgeabr Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEABR"), AV10cAmgeAbr) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgesta Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGESTA"), AV11cAmGesta) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Camgeanio Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAMGEANIO"), ",", ".") != Convert.ToDecimal( AV12cAmgeAnio )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E21082 ();
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

      protected void WE082( )
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

      protected void PA082( )
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
         SubsflControlProps_842( ) ;
         while ( nGXsfl_84_idx <= nRC_GXsfl_84 )
         {
            sendrow_842( ) ;
            nGXsfl_84_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1);
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_84_idx), 4, 0), 4, "0");
            SubsflControlProps_842( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid1Container)) ;
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        String AV6cAmGecod ,
                                        String AV7cAmGedes ,
                                        long AV8cAmGeval ,
                                        String AV9cAmGedet ,
                                        String AV10cAmgeAbr ,
                                        String AV11cAmGesta ,
                                        short AV12cAmgeAnio )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID1_nCurrentRecord = 0;
         RF082( ) ;
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         send_integrity_footer_hashes( ) ;
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_AMGECOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A1AmGecod, "99999")), context));
         GxWebStd.gx_hidden_field( context, "AMGECOD", StringUtil.RTrim( A1AmGecod));
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
         RF082( ) ;
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

      protected void RF082( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 84;
         nGXsfl_84_idx = 1;
         sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_84_idx), 4, 0), 4, "0");
         SubsflControlProps_842( ) ;
         bGXsfl_84_Refreshing = true;
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
            SubsflControlProps_842( ) ;
            GXPagingFrom2 = (int)(GRID1_nFirstRecordOnPage);
            GXPagingTo2 = (int)(subGrid1_fnc_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cAmGedes ,
                                                 AV8cAmGeval ,
                                                 AV9cAmGedet ,
                                                 AV10cAmgeAbr ,
                                                 AV11cAmGesta ,
                                                 AV12cAmgeAnio ,
                                                 A7AmGedes ,
                                                 A11AmGeval ,
                                                 A12AmGedet ,
                                                 A20AmgeAbr ,
                                                 A8AmGesta ,
                                                 A14AmgeAnio ,
                                                 A1AmGecod ,
                                                 AV6cAmGecod } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING
                                                 }
            } ) ;
            lV6cAmGecod = StringUtil.PadR( StringUtil.RTrim( AV6cAmGecod), 5, "%");
            lV7cAmGedes = StringUtil.PadR( StringUtil.RTrim( AV7cAmGedes), 30, "%");
            lV9cAmGedet = StringUtil.PadR( StringUtil.RTrim( AV9cAmGedet), 50, "%");
            lV10cAmgeAbr = StringUtil.PadR( StringUtil.RTrim( AV10cAmgeAbr), 3, "%");
            lV11cAmGesta = StringUtil.PadR( StringUtil.RTrim( AV11cAmGesta), 1, "%");
            /* Using cursor H00082 */
            pr_default.execute(0, new Object[] {lV6cAmGecod, lV7cAmGedes, AV8cAmGeval, lV9cAmGedet, lV10cAmgeAbr, lV11cAmGesta, AV12cAmgeAnio, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_84_idx), 4, 0), 4, "0");
            SubsflControlProps_842( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( GRID1_nCurrentRecord < subGrid1_fnc_Recordsperpage( ) ) ) )
            {
               A14AmgeAnio = H00082_A14AmgeAnio[0];
               n14AmgeAnio = H00082_n14AmgeAnio[0];
               A8AmGesta = H00082_A8AmGesta[0];
               n8AmGesta = H00082_n8AmGesta[0];
               A20AmgeAbr = H00082_A20AmgeAbr[0];
               n20AmgeAbr = H00082_n20AmgeAbr[0];
               A12AmGedet = H00082_A12AmGedet[0];
               n12AmGedet = H00082_n12AmGedet[0];
               A11AmGeval = H00082_A11AmGeval[0];
               n11AmGeval = H00082_n11AmGeval[0];
               A7AmGedes = H00082_A7AmGedes[0];
               n7AmGedes = H00082_n7AmGedes[0];
               A1AmGecod = H00082_A1AmGecod[0];
               /* Execute user event: Load */
               E20082 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB080( ) ;
         }
         bGXsfl_84_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes082( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_AMGECOD"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A1AmGecod, "99999")), context));
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
                                              AV7cAmGedes ,
                                              AV8cAmGeval ,
                                              AV9cAmGedet ,
                                              AV10cAmgeAbr ,
                                              AV11cAmGesta ,
                                              AV12cAmgeAnio ,
                                              A7AmGedes ,
                                              A11AmGeval ,
                                              A12AmGedet ,
                                              A20AmgeAbr ,
                                              A8AmGesta ,
                                              A14AmgeAnio ,
                                              A1AmGecod ,
                                              AV6cAmGecod } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV6cAmGecod = StringUtil.PadR( StringUtil.RTrim( AV6cAmGecod), 5, "%");
         lV7cAmGedes = StringUtil.PadR( StringUtil.RTrim( AV7cAmGedes), 30, "%");
         lV9cAmGedet = StringUtil.PadR( StringUtil.RTrim( AV9cAmGedet), 50, "%");
         lV10cAmgeAbr = StringUtil.PadR( StringUtil.RTrim( AV10cAmgeAbr), 3, "%");
         lV11cAmGesta = StringUtil.PadR( StringUtil.RTrim( AV11cAmGesta), 1, "%");
         /* Using cursor H00083 */
         pr_default.execute(1, new Object[] {lV6cAmGecod, lV7cAmGedes, AV8cAmGeval, lV9cAmGedet, lV10cAmgeAbr, lV11cAmGesta, AV12cAmgeAnio});
         GRID1_nRecordCount = H00083_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmGecod, AV7cAmGedes, AV8cAmGeval, AV9cAmGedet, AV10cAmgeAbr, AV11cAmGesta, AV12cAmgeAnio) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmGecod, AV7cAmGedes, AV8cAmGeval, AV9cAmGedet, AV10cAmgeAbr, AV11cAmGesta, AV12cAmgeAnio) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmGecod, AV7cAmGedes, AV8cAmGeval, AV9cAmGedet, AV10cAmgeAbr, AV11cAmGesta, AV12cAmgeAnio) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmGecod, AV7cAmGedes, AV8cAmGeval, AV9cAmGedet, AV10cAmgeAbr, AV11cAmGesta, AV12cAmgeAnio) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cAmGecod, AV7cAmGedes, AV8cAmGeval, AV9cAmGedet, AV10cAmgeAbr, AV11cAmGesta, AV12cAmgeAnio) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void before_start_formulas( )
      {
         context.Gx_err = 0;
      }

      protected void STRUP080( )
      {
         /* Before Start, stand alone formulas. */
         before_start_formulas( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E19082 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_84 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read variables values. */
            AV6cAmGecod = cgiGet( edtavCamgecod_Internalname);
            AssignAttri("", false, "AV6cAmGecod", AV6cAmGecod);
            AV7cAmGedes = StringUtil.Upper( cgiGet( edtavCamgedes_Internalname));
            AssignAttri("", false, "AV7cAmGedes", AV7cAmGedes);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCamgeval_Internalname), ",", ".") < Convert.ToDecimal( -999999999L )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCamgeval_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCAMGEVAL");
               GX_FocusControl = edtavCamgeval_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cAmGeval = 0;
               AssignAttri("", false, "AV8cAmGeval", StringUtil.LTrimStr( (decimal)(AV8cAmGeval), 10, 0));
            }
            else
            {
               AV8cAmGeval = (long)(context.localUtil.CToN( cgiGet( edtavCamgeval_Internalname), ",", "."));
               AssignAttri("", false, "AV8cAmGeval", StringUtil.LTrimStr( (decimal)(AV8cAmGeval), 10, 0));
            }
            AV9cAmGedet = StringUtil.Upper( cgiGet( edtavCamgedet_Internalname));
            AssignAttri("", false, "AV9cAmGedet", AV9cAmGedet);
            AV10cAmgeAbr = cgiGet( edtavCamgeabr_Internalname);
            AssignAttri("", false, "AV10cAmgeAbr", AV10cAmgeAbr);
            AV11cAmGesta = cgiGet( edtavCamgesta_Internalname);
            AssignAttri("", false, "AV11cAmGesta", AV11cAmGesta);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCamgeanio_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCamgeanio_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCAMGEANIO");
               GX_FocusControl = edtavCamgeanio_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12cAmgeAnio = 0;
               AssignAttri("", false, "AV12cAmgeAnio", StringUtil.LTrimStr( (decimal)(AV12cAmgeAnio), 4, 0));
            }
            else
            {
               AV12cAmgeAnio = (short)(context.localUtil.CToN( cgiGet( edtavCamgeanio_Internalname), ",", "."));
               AssignAttri("", false, "AV12cAmgeAnio", StringUtil.LTrimStr( (decimal)(AV12cAmgeAnio), 4, 0));
            }
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGECOD"), AV6cAmGecod) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEDES"), AV7cAmGedes) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAMGEVAL"), ",", ".") != Convert.ToDecimal( AV8cAmGeval )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEDET"), AV9cAmGedet) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGEABR"), AV10cAmgeAbr) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCAMGESTA"), AV11cAmGesta) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAMGEANIO"), ",", ".") != Convert.ToDecimal( AV12cAmgeAnio )) )
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
         E19082 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19082( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Ambiente General", "", "", "", "", "", "", "", "");
         AssignProp("", false, "FORM", "Caption", Form.Caption, true);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E20082( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         AssignAttri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV17Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_842( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_84_Refreshing )
         {
            context.DoAjaxLoad(84, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E21082 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21082( )
      {
         /* Enter Routine */
         AV13pAmGecod = A1AmGecod;
         AssignAttri("", false, "AV13pAmGecod", AV13pAmGecod);
         context.setWebReturnParms(new Object[] {(String)AV13pAmGecod});
         context.setWebReturnParmsMetadata(new Object[] {"AV13pAmGecod"});
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
         AV13pAmGecod = (String)getParm(obj,0);
         AssignAttri("", false, "AV13pAmGecod", AV13pAmGecod);
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
         PA082( ) ;
         WS082( ) ;
         WE082( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20224211026329", true, true);
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
         context.AddJavascriptSource("gx0010.js", "?20224211026329", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtAmGecod_Internalname = "AMGECOD_"+sGXsfl_84_idx;
         edtAmGedes_Internalname = "AMGEDES_"+sGXsfl_84_idx;
         edtAmGeval_Internalname = "AMGEVAL_"+sGXsfl_84_idx;
         edtAmGedet_Internalname = "AMGEDET_"+sGXsfl_84_idx;
         edtAmgeAbr_Internalname = "AMGEABR_"+sGXsfl_84_idx;
         edtAmGesta_Internalname = "AMGESTA_"+sGXsfl_84_idx;
         edtAmgeAnio_Internalname = "AMGEANIO_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtAmGecod_Internalname = "AMGECOD_"+sGXsfl_84_fel_idx;
         edtAmGedes_Internalname = "AMGEDES_"+sGXsfl_84_fel_idx;
         edtAmGeval_Internalname = "AMGEVAL_"+sGXsfl_84_fel_idx;
         edtAmGedet_Internalname = "AMGEDET_"+sGXsfl_84_fel_idx;
         edtAmgeAbr_Internalname = "AMGEABR_"+sGXsfl_84_fel_idx;
         edtAmGesta_Internalname = "AMGESTA_"+sGXsfl_84_fel_idx;
         edtAmgeAnio_Internalname = "AMGEANIO_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB080( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_84_idx <= subGrid1_fnc_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_84_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_84_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A1AmGecod))+"'"+"]);";
            AssignProp("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_84_Refreshing);
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGecod_Internalname,StringUtil.RTrim( A1AmGecod),StringUtil.RTrim( context.localUtil.Format( A1AmGecod, "99999")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmGecod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"codmediano",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtAmGedes_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A1AmGecod))+"'"+"]);";
            AssignProp("", false, edtAmGedes_Internalname, "Link", edtAmGedes_Link, !bGXsfl_84_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGedes_Internalname,StringUtil.RTrim( A7AmGedes),StringUtil.RTrim( context.localUtil.Format( A7AmGedes, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtAmGedes_Link,(String)"",(String)"",(String)"",(String)edtAmGedes_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"nommediano",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGeval_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11AmGeval), 13, 0, ",", "")),context.localUtil.Format( (decimal)(A11AmGeval), "Z,ZZZ,ZZZ,ZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmGeval_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"valpago",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGedet_Internalname,StringUtil.RTrim( A12AmGedet),StringUtil.RTrim( context.localUtil.Format( A12AmGedet, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmGedet_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"nomlargo",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeAbr_Internalname,StringUtil.RTrim( A20AmgeAbr),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeAbr_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGesta_Internalname,StringUtil.RTrim( A8AmGesta),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmGesta_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A14AmgeAnio), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A14AmgeAnio), "9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeAnio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
            send_integrity_lvl_hashes082( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1);
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_84_idx), 4, 0), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblLblamgecodfilter_Internalname = "LBLAMGECODFILTER";
         edtavCamgecod_Internalname = "vCAMGECOD";
         divAmgecodfiltercontainer_Internalname = "AMGECODFILTERCONTAINER";
         lblLblamgedesfilter_Internalname = "LBLAMGEDESFILTER";
         edtavCamgedes_Internalname = "vCAMGEDES";
         divAmgedesfiltercontainer_Internalname = "AMGEDESFILTERCONTAINER";
         lblLblamgevalfilter_Internalname = "LBLAMGEVALFILTER";
         edtavCamgeval_Internalname = "vCAMGEVAL";
         divAmgevalfiltercontainer_Internalname = "AMGEVALFILTERCONTAINER";
         lblLblamgedetfilter_Internalname = "LBLAMGEDETFILTER";
         edtavCamgedet_Internalname = "vCAMGEDET";
         divAmgedetfiltercontainer_Internalname = "AMGEDETFILTERCONTAINER";
         lblLblamgeabrfilter_Internalname = "LBLAMGEABRFILTER";
         edtavCamgeabr_Internalname = "vCAMGEABR";
         divAmgeabrfiltercontainer_Internalname = "AMGEABRFILTERCONTAINER";
         lblLblamgestafilter_Internalname = "LBLAMGESTAFILTER";
         edtavCamgesta_Internalname = "vCAMGESTA";
         divAmgestafiltercontainer_Internalname = "AMGESTAFILTERCONTAINER";
         lblLblamgeaniofilter_Internalname = "LBLAMGEANIOFILTER";
         edtavCamgeanio_Internalname = "vCAMGEANIO";
         divAmgeaniofiltercontainer_Internalname = "AMGEANIOFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtAmGecod_Internalname = "AMGECOD";
         edtAmGedes_Internalname = "AMGEDES";
         edtAmGeval_Internalname = "AMGEVAL";
         edtAmGedet_Internalname = "AMGEDET";
         edtAmgeAbr_Internalname = "AMGEABR";
         edtAmGesta_Internalname = "AMGESTA";
         edtAmgeAnio_Internalname = "AMGEANIO";
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
         edtAmgeAnio_Jsonclick = "";
         edtAmGesta_Jsonclick = "";
         edtAmgeAbr_Jsonclick = "";
         edtAmGedet_Jsonclick = "";
         edtAmGeval_Jsonclick = "";
         edtAmGedes_Jsonclick = "";
         edtAmGecod_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtAmGedes_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCamgeanio_Jsonclick = "";
         edtavCamgeanio_Enabled = 1;
         edtavCamgeanio_Visible = 1;
         edtavCamgesta_Jsonclick = "";
         edtavCamgesta_Enabled = 1;
         edtavCamgesta_Visible = 1;
         edtavCamgeabr_Jsonclick = "";
         edtavCamgeabr_Enabled = 1;
         edtavCamgeabr_Visible = 1;
         edtavCamgedet_Jsonclick = "";
         edtavCamgedet_Enabled = 1;
         edtavCamgedet_Visible = 1;
         edtavCamgeval_Jsonclick = "";
         edtavCamgeval_Enabled = 1;
         edtavCamgeval_Visible = 1;
         edtavCamgedes_Jsonclick = "";
         edtavCamgedes_Enabled = 1;
         edtavCamgedes_Visible = 1;
         edtavCamgecod_Jsonclick = "";
         edtavCamgecod_Enabled = 1;
         edtavCamgecod_Visible = 1;
         divAmgeaniofiltercontainer_Class = "AdvancedContainerItem";
         divAmgestafiltercontainer_Class = "AdvancedContainerItem";
         divAmgeabrfiltercontainer_Class = "AdvancedContainerItem";
         divAmgedetfiltercontainer_Class = "AdvancedContainerItem";
         divAmgevalfiltercontainer_Class = "AdvancedContainerItem";
         divAmgedesfiltercontainer_Class = "AdvancedContainerItem";
         divAmgecodfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Ambiente General";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmGecod',fld:'vCAMGECOD',pic:'99999'},{av:'AV7cAmGedes',fld:'vCAMGEDES',pic:'@!'},{av:'AV8cAmGeval',fld:'vCAMGEVAL',pic:'Z,ZZZ,ZZZ,ZZ9'},{av:'AV9cAmGedet',fld:'vCAMGEDET',pic:'@!'},{av:'AV10cAmgeAbr',fld:'vCAMGEABR',pic:''},{av:'AV11cAmGesta',fld:'vCAMGESTA',pic:''},{av:'AV12cAmgeAnio',fld:'vCAMGEANIO',pic:'9999'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E18081',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLAMGECODFILTER.CLICK","{handler:'E11081',iparms:[{av:'divAmgecodfiltercontainer_Class',ctrl:'AMGECODFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGECODFILTER.CLICK",",oparms:[{av:'divAmgecodfiltercontainer_Class',ctrl:'AMGECODFILTERCONTAINER',prop:'Class'},{av:'edtavCamgecod_Visible',ctrl:'vCAMGECOD',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEDESFILTER.CLICK","{handler:'E12081',iparms:[{av:'divAmgedesfiltercontainer_Class',ctrl:'AMGEDESFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEDESFILTER.CLICK",",oparms:[{av:'divAmgedesfiltercontainer_Class',ctrl:'AMGEDESFILTERCONTAINER',prop:'Class'},{av:'edtavCamgedes_Visible',ctrl:'vCAMGEDES',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEVALFILTER.CLICK","{handler:'E13081',iparms:[{av:'divAmgevalfiltercontainer_Class',ctrl:'AMGEVALFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEVALFILTER.CLICK",",oparms:[{av:'divAmgevalfiltercontainer_Class',ctrl:'AMGEVALFILTERCONTAINER',prop:'Class'},{av:'edtavCamgeval_Visible',ctrl:'vCAMGEVAL',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEDETFILTER.CLICK","{handler:'E14081',iparms:[{av:'divAmgedetfiltercontainer_Class',ctrl:'AMGEDETFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEDETFILTER.CLICK",",oparms:[{av:'divAmgedetfiltercontainer_Class',ctrl:'AMGEDETFILTERCONTAINER',prop:'Class'},{av:'edtavCamgedet_Visible',ctrl:'vCAMGEDET',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEABRFILTER.CLICK","{handler:'E15081',iparms:[{av:'divAmgeabrfiltercontainer_Class',ctrl:'AMGEABRFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEABRFILTER.CLICK",",oparms:[{av:'divAmgeabrfiltercontainer_Class',ctrl:'AMGEABRFILTERCONTAINER',prop:'Class'},{av:'edtavCamgeabr_Visible',ctrl:'vCAMGEABR',prop:'Visible'}]}");
         setEventMetadata("LBLAMGESTAFILTER.CLICK","{handler:'E16081',iparms:[{av:'divAmgestafiltercontainer_Class',ctrl:'AMGESTAFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGESTAFILTER.CLICK",",oparms:[{av:'divAmgestafiltercontainer_Class',ctrl:'AMGESTAFILTERCONTAINER',prop:'Class'},{av:'edtavCamgesta_Visible',ctrl:'vCAMGESTA',prop:'Visible'}]}");
         setEventMetadata("LBLAMGEANIOFILTER.CLICK","{handler:'E17081',iparms:[{av:'divAmgeaniofiltercontainer_Class',ctrl:'AMGEANIOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAMGEANIOFILTER.CLICK",",oparms:[{av:'divAmgeaniofiltercontainer_Class',ctrl:'AMGEANIOFILTERCONTAINER',prop:'Class'},{av:'edtavCamgeanio_Visible',ctrl:'vCAMGEANIO',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E21082',iparms:[{av:'A1AmGecod',fld:'AMGECOD',pic:'99999',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV13pAmGecod',fld:'vPAMGECOD',pic:'99999'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmGecod',fld:'vCAMGECOD',pic:'99999'},{av:'AV7cAmGedes',fld:'vCAMGEDES',pic:'@!'},{av:'AV8cAmGeval',fld:'vCAMGEVAL',pic:'Z,ZZZ,ZZZ,ZZ9'},{av:'AV9cAmGedet',fld:'vCAMGEDET',pic:'@!'},{av:'AV10cAmgeAbr',fld:'vCAMGEABR',pic:''},{av:'AV11cAmGesta',fld:'vCAMGESTA',pic:''},{av:'AV12cAmgeAnio',fld:'vCAMGEANIO',pic:'9999'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmGecod',fld:'vCAMGECOD',pic:'99999'},{av:'AV7cAmGedes',fld:'vCAMGEDES',pic:'@!'},{av:'AV8cAmGeval',fld:'vCAMGEVAL',pic:'Z,ZZZ,ZZZ,ZZ9'},{av:'AV9cAmGedet',fld:'vCAMGEDET',pic:'@!'},{av:'AV10cAmgeAbr',fld:'vCAMGEABR',pic:''},{av:'AV11cAmGesta',fld:'vCAMGESTA',pic:''},{av:'AV12cAmgeAnio',fld:'vCAMGEANIO',pic:'9999'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmGecod',fld:'vCAMGECOD',pic:'99999'},{av:'AV7cAmGedes',fld:'vCAMGEDES',pic:'@!'},{av:'AV8cAmGeval',fld:'vCAMGEVAL',pic:'Z,ZZZ,ZZZ,ZZ9'},{av:'AV9cAmGedet',fld:'vCAMGEDET',pic:'@!'},{av:'AV10cAmgeAbr',fld:'vCAMGEABR',pic:''},{av:'AV11cAmGesta',fld:'vCAMGESTA',pic:''},{av:'AV12cAmgeAnio',fld:'vCAMGEANIO',pic:'9999'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cAmGecod',fld:'vCAMGECOD',pic:'99999'},{av:'AV7cAmGedes',fld:'vCAMGEDES',pic:'@!'},{av:'AV8cAmGeval',fld:'vCAMGEVAL',pic:'Z,ZZZ,ZZZ,ZZ9'},{av:'AV9cAmGedet',fld:'vCAMGEDET',pic:'@!'},{av:'AV10cAmgeAbr',fld:'vCAMGEABR',pic:''},{av:'AV11cAmGesta',fld:'vCAMGESTA',pic:''},{av:'AV12cAmgeAnio',fld:'vCAMGEANIO',pic:'9999'}]");
         setEventMetadata("GRID1_LASTPAGE",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Amgeanio',iparms:[]");
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
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV6cAmGecod = "";
         AV7cAmGedes = "";
         AV9cAmGedet = "";
         AV10cAmgeAbr = "";
         AV11cAmGesta = "";
         AV13pAmGecod = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblamgecodfilter_Jsonclick = "";
         TempTags = "";
         lblLblamgedesfilter_Jsonclick = "";
         lblLblamgevalfilter_Jsonclick = "";
         lblLblamgedetfilter_Jsonclick = "";
         lblLblamgeabrfilter_Jsonclick = "";
         lblLblamgestafilter_Jsonclick = "";
         lblLblamgeaniofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A1AmGecod = "";
         A7AmGedes = "";
         A12AmGedet = "";
         A20AmgeAbr = "";
         A8AmGesta = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         scmdbuf = "";
         lV6cAmGecod = "";
         lV7cAmGedes = "";
         lV9cAmGedet = "";
         lV10cAmgeAbr = "";
         lV11cAmGesta = "";
         H00082_A14AmgeAnio = new short[1] ;
         H00082_n14AmgeAnio = new bool[] {false} ;
         H00082_A8AmGesta = new String[] {""} ;
         H00082_n8AmGesta = new bool[] {false} ;
         H00082_A20AmgeAbr = new String[] {""} ;
         H00082_n20AmgeAbr = new bool[] {false} ;
         H00082_A12AmGedet = new String[] {""} ;
         H00082_n12AmGedet = new bool[] {false} ;
         H00082_A11AmGeval = new long[1] ;
         H00082_n11AmGeval = new bool[] {false} ;
         H00082_A7AmGedes = new String[] {""} ;
         H00082_n7AmGedes = new bool[] {false} ;
         H00082_A1AmGecod = new String[] {""} ;
         H00083_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0010__default(),
            new Object[][] {
                new Object[] {
               H00082_A14AmgeAnio, H00082_n14AmgeAnio, H00082_A8AmGesta, H00082_n8AmGesta, H00082_A20AmgeAbr, H00082_n20AmgeAbr, H00082_A12AmGedet, H00082_n12AmGedet, H00082_A11AmGeval, H00082_n11AmGeval,
               H00082_A7AmGedes, H00082_n7AmGedes, H00082_A1AmGecod
               }
               , new Object[] {
               H00083_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short GRID1_nEOF ;
      private short nGotPars ;
      private short GxWebError ;
      private short AV12cAmgeAnio ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A14AmgeAnio ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int nRC_GXsfl_84 ;
      private int nGXsfl_84_idx=1 ;
      private int subGrid1_Rows ;
      private int edtavCamgecod_Visible ;
      private int edtavCamgecod_Enabled ;
      private int edtavCamgedes_Visible ;
      private int edtavCamgedes_Enabled ;
      private int edtavCamgeval_Enabled ;
      private int edtavCamgeval_Visible ;
      private int edtavCamgedet_Visible ;
      private int edtavCamgedet_Enabled ;
      private int edtavCamgeabr_Visible ;
      private int edtavCamgeabr_Enabled ;
      private int edtavCamgesta_Visible ;
      private int edtavCamgesta_Enabled ;
      private int edtavCamgeanio_Enabled ;
      private int edtavCamgeanio_Visible ;
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
      private long AV8cAmGeval ;
      private long A11AmGeval ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divAmgecodfiltercontainer_Class ;
      private String divAmgedesfiltercontainer_Class ;
      private String divAmgevalfiltercontainer_Class ;
      private String divAmgedetfiltercontainer_Class ;
      private String divAmgeabrfiltercontainer_Class ;
      private String divAmgestafiltercontainer_Class ;
      private String divAmgeaniofiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_84_idx="0001" ;
      private String AV6cAmGecod ;
      private String AV7cAmGedes ;
      private String AV9cAmGedet ;
      private String AV10cAmgeAbr ;
      private String AV11cAmGesta ;
      private String AV13pAmGecod ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divAmgecodfiltercontainer_Internalname ;
      private String lblLblamgecodfilter_Internalname ;
      private String lblLblamgecodfilter_Jsonclick ;
      private String edtavCamgecod_Internalname ;
      private String TempTags ;
      private String edtavCamgecod_Jsonclick ;
      private String divAmgedesfiltercontainer_Internalname ;
      private String lblLblamgedesfilter_Internalname ;
      private String lblLblamgedesfilter_Jsonclick ;
      private String edtavCamgedes_Internalname ;
      private String edtavCamgedes_Jsonclick ;
      private String divAmgevalfiltercontainer_Internalname ;
      private String lblLblamgevalfilter_Internalname ;
      private String lblLblamgevalfilter_Jsonclick ;
      private String edtavCamgeval_Internalname ;
      private String edtavCamgeval_Jsonclick ;
      private String divAmgedetfiltercontainer_Internalname ;
      private String lblLblamgedetfilter_Internalname ;
      private String lblLblamgedetfilter_Jsonclick ;
      private String edtavCamgedet_Internalname ;
      private String edtavCamgedet_Jsonclick ;
      private String divAmgeabrfiltercontainer_Internalname ;
      private String lblLblamgeabrfilter_Internalname ;
      private String lblLblamgeabrfilter_Jsonclick ;
      private String edtavCamgeabr_Internalname ;
      private String edtavCamgeabr_Jsonclick ;
      private String divAmgestafiltercontainer_Internalname ;
      private String lblLblamgestafilter_Internalname ;
      private String lblLblamgestafilter_Jsonclick ;
      private String edtavCamgesta_Internalname ;
      private String edtavCamgesta_Jsonclick ;
      private String divAmgeaniofiltercontainer_Internalname ;
      private String lblLblamgeaniofilter_Internalname ;
      private String lblLblamgeaniofilter_Jsonclick ;
      private String edtavCamgeanio_Internalname ;
      private String edtavCamgeanio_Jsonclick ;
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
      private String A1AmGecod ;
      private String A7AmGedes ;
      private String edtAmGedes_Link ;
      private String A12AmGedet ;
      private String A20AmgeAbr ;
      private String A8AmGesta ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtAmGecod_Internalname ;
      private String edtAmGedes_Internalname ;
      private String edtAmGeval_Internalname ;
      private String edtAmGedet_Internalname ;
      private String edtAmgeAbr_Internalname ;
      private String edtAmGesta_Internalname ;
      private String edtAmgeAnio_Internalname ;
      private String scmdbuf ;
      private String lV6cAmGecod ;
      private String lV7cAmGedes ;
      private String lV9cAmGedet ;
      private String lV10cAmgeAbr ;
      private String lV11cAmGesta ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtAmGecod_Jsonclick ;
      private String edtAmGedes_Jsonclick ;
      private String edtAmGeval_Jsonclick ;
      private String edtAmGedet_Jsonclick ;
      private String edtAmgeAbr_Jsonclick ;
      private String edtAmGesta_Jsonclick ;
      private String edtAmgeAnio_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_84_Refreshing=false ;
      private bool n7AmGedes ;
      private bool n11AmGeval ;
      private bool n12AmGedet ;
      private bool n20AmgeAbr ;
      private bool n8AmGesta ;
      private bool n14AmgeAnio ;
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
      private short[] H00082_A14AmgeAnio ;
      private bool[] H00082_n14AmgeAnio ;
      private String[] H00082_A8AmGesta ;
      private bool[] H00082_n8AmGesta ;
      private String[] H00082_A20AmgeAbr ;
      private bool[] H00082_n20AmgeAbr ;
      private String[] H00082_A12AmGedet ;
      private bool[] H00082_n12AmGedet ;
      private long[] H00082_A11AmGeval ;
      private bool[] H00082_n11AmGeval ;
      private String[] H00082_A7AmGedes ;
      private bool[] H00082_n7AmGedes ;
      private String[] H00082_A1AmGecod ;
      private long[] H00083_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pAmGecod ;
      private GXWebForm Form ;
   }

   public class gx0010__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00082( IGxContext context ,
                                             String AV7cAmGedes ,
                                             long AV8cAmGeval ,
                                             String AV9cAmGedet ,
                                             String AV10cAmgeAbr ,
                                             String AV11cAmGesta ,
                                             short AV12cAmgeAnio ,
                                             String A7AmGedes ,
                                             long A11AmGeval ,
                                             String A12AmGedet ,
                                             String A20AmgeAbr ,
                                             String A8AmGesta ,
                                             short A14AmgeAnio ,
                                             String A1AmGecod ,
                                             String AV6cAmGecod )
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
         sSelectString = " [AmgeAnio], [AmGesta], [AmgeAbr], [AmGedet], [AmGeval], [AmGedes], [AmGecod]";
         sFromString = " FROM [agAmGe]";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([AmGecod] like @lV6cAmGecod)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cAmGedes)) )
         {
            sWhereString = sWhereString + " and ([AmGedes] like @lV7cAmGedes)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV8cAmGeval) )
         {
            sWhereString = sWhereString + " and ([AmGeval] >= @AV8cAmGeval)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cAmGedet)) )
         {
            sWhereString = sWhereString + " and ([AmGedet] like @lV9cAmGedet)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cAmgeAbr)) )
         {
            sWhereString = sWhereString + " and ([AmgeAbr] like @lV10cAmgeAbr)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cAmGesta)) )
         {
            sWhereString = sWhereString + " and ([AmGesta] like @lV11cAmGesta)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV12cAmgeAnio) )
         {
            sWhereString = sWhereString + " and ([AmgeAnio] >= @AV12cAmgeAnio)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [AmGecod]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + sOrderString + "" + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00083( IGxContext context ,
                                             String AV7cAmGedes ,
                                             long AV8cAmGeval ,
                                             String AV9cAmGedet ,
                                             String AV10cAmgeAbr ,
                                             String AV11cAmGesta ,
                                             short AV12cAmgeAnio ,
                                             String A7AmGedes ,
                                             long A11AmGeval ,
                                             String A12AmGedet ,
                                             String A20AmgeAbr ,
                                             String A8AmGesta ,
                                             short A14AmgeAnio ,
                                             String A1AmGecod ,
                                             String AV6cAmGecod )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [agAmGe]";
         scmdbuf = scmdbuf + " WHERE ([AmGecod] like @lV6cAmGecod)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cAmGedes)) )
         {
            sWhereString = sWhereString + " and ([AmGedes] like @lV7cAmGedes)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV8cAmGeval) )
         {
            sWhereString = sWhereString + " and ([AmGeval] >= @AV8cAmGeval)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cAmGedet)) )
         {
            sWhereString = sWhereString + " and ([AmGedet] like @lV9cAmGedet)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cAmgeAbr)) )
         {
            sWhereString = sWhereString + " and ([AmgeAbr] like @lV10cAmgeAbr)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cAmGesta)) )
         {
            sWhereString = sWhereString + " and ([AmGesta] like @lV11cAmGesta)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV12cAmgeAnio) )
         {
            sWhereString = sWhereString + " and ([AmgeAnio] >= @AV12cAmgeAnio)";
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
                     return conditional_H00082(context, (String)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] );
               case 1 :
                     return conditional_H00083(context, (String)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] );
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
          Object[] prmH00082 ;
          prmH00082 = new Object[] {
          new Object[] {"@lV6cAmGecod",SqlDbType.NChar,5,0} ,
          new Object[] {"@lV7cAmGedes",SqlDbType.NChar,30,0} ,
          new Object[] {"@AV8cAmGeval",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV9cAmGedet",SqlDbType.NChar,50,0} ,
          new Object[] {"@lV10cAmgeAbr",SqlDbType.NChar,3,0} ,
          new Object[] {"@lV11cAmGesta",SqlDbType.NChar,1,0} ,
          new Object[] {"@AV12cAmgeAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00083 ;
          prmH00083 = new Object[] {
          new Object[] {"@lV6cAmGecod",SqlDbType.NChar,5,0} ,
          new Object[] {"@lV7cAmGedes",SqlDbType.NChar,30,0} ,
          new Object[] {"@AV8cAmGeval",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV9cAmGedet",SqlDbType.NChar,50,0} ,
          new Object[] {"@lV10cAmgeAbr",SqlDbType.NChar,3,0} ,
          new Object[] {"@lV11cAmGesta",SqlDbType.NChar,1,0} ,
          new Object[] {"@AV12cAmgeAnio",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00082", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00082,11, GxCacheFrequency.OFF ,false,false )
             ,new CursorDef("H00083", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00083,1, GxCacheFrequency.OFF ,false,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getString(3, 3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getString(6, 30) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getString(7, 5) ;
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
                   stmt.SetParameter(sIdx, (long)parms[12]);
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
                   stmt.SetParameter(sIdx, (short)parms[16]);
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
                   stmt.SetParameter(sIdx, (long)parms[9]);
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
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                return;
       }
    }

 }

}
