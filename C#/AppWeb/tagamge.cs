/*
               File: TagAmGe
        Description: Ambiente General
             Author: GeneXus C# Generator version 16_0_11-144151
       Generated on: 4/21/2022 10:26:35.61
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
   public class tagamge : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid2") == 0 )
         {
            nRC_GXsfl_97 = (int)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_97_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_97_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGrid2_newrow( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid3") == 0 )
         {
            nRC_GXsfl_104 = (int)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_104_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_104_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGrid3_newrow( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid4") == 0 )
         {
            nRC_GXsfl_114 = (int)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_114_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_114_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGrid4_newrow( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
         {
            nRC_GXsfl_91 = (int)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_91_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_91_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGrid1_newrow( ) ;
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
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
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
         if ( ! context.isSpaRequest( ) )
         {
            if ( context.ExposeMetadata( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_11-144151", 0) ;
            }
            Form.Meta.addItem("description", "Ambiente General", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         if ( ! context.isAjaxRequest( ) )
         {
            GX_FocusControl = edtAmGecod_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public tagamge( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsSistema = context.GetDataStore("Sistema");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public tagamge( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsSistema = context.GetDataStore("Sistema");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkAmgeMailSecure = new GXCheckbox();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
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

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            DrawControls( ) ;
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void DrawControls( )
      {
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTable3_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"AMGECOD"+"'), id:'"+"AMGECOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "middle", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Codigo:", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTable4_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAmGecod_Internalname, "Codigo:", "col-sm-3 ", 0, true, "");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAmGecod_Internalname, StringUtil.RTrim( A1AmGecod), StringUtil.RTrim( context.localUtil.Format( A1AmGecod, "99999")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAmGecod_Jsonclick, 0, "", "", "", "", "", 1, edtAmGecod_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 0, -1, -1, true, "codmediano", "left", true, "", "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_get_Internalname, "", "=>", bttBtn_get_Jsonclick, 6, "=>", "", StyleString, ClassString, bttBtn_get_Visible, bttBtn_get_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EGET."+"'", TempTags, "", context.GetButtonType( ), "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAmGedes_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAmGedes_Internalname, "Descripción:", "col-sm-3 ", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAmGedes_Internalname, StringUtil.RTrim( A7AmGedes), StringUtil.RTrim( context.localUtil.Format( A7AmGedes, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(this,47);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAmGedes_Jsonclick, 0, "", "", "", "", "", 1, edtAmGedes_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 0, -1, -1, true, "nommediano", "left", true, "", "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAmGeval_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAmGeval_Internalname, "Valor:", "col-sm-3 ", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAmGeval_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11AmGeval), 13, 0, ",", "")), ((edtAmGeval_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A11AmGeval), "Z,ZZZ,ZZZ,ZZ9")) : context.localUtil.Format( (decimal)(A11AmGeval), "Z,ZZZ,ZZZ,ZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAmGeval_Jsonclick, 0, "", "", "", "", "", 1, edtAmGeval_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 0, -1, 0, true, "valpago", "right", false, "", "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAmGedet_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAmGedet_Internalname, "Detalle:", "col-sm-3 ", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAmGedet_Internalname, StringUtil.RTrim( A12AmGedet), StringUtil.RTrim( context.localUtil.Format( A12AmGedet, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(this,57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAmGedet_Jsonclick, 0, "", "", "", "", "", 1, edtAmGedet_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 0, -1, -1, true, "nomlargo", "left", true, "", "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAmGesta_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAmGesta_Internalname, "Estado:", "col-sm-3 ", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAmGesta_Internalname, StringUtil.RTrim( A8AmGesta), StringUtil.RTrim( context.localUtil.Format( A8AmGesta, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAmGesta_Jsonclick, 0, "", "", "", "", "", 1, edtAmGesta_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 0, -1, -1, true, "", "left", true, "", "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAmGeobs_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAmGeobs_Internalname, "Observación:", "col-sm-3 ", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Multiple line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_html_textarea( context, edtAmGeobs_Internalname, A13AmGeobs, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,67);\"", 0, 1, edtAmGeobs_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "3000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAmgeAnio_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAmgeAnio_Internalname, "Año_", "col-sm-3 ", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAmgeAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A14AmgeAnio), 4, 0, ",", "")), ((edtAmgeAnio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A14AmgeAnio), "9999")) : context.localUtil.Format( (decimal)(A14AmgeAnio), "9999")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAmgeAnio_Jsonclick, 0, "", "", "", "", "", 1, edtAmgeAnio_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 0, -1, 0, true, "", "right", false, "", "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAmGeusrlog_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAmGeusrlog_Internalname, "AmGeusrlog", "col-sm-3 ", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAmGeusrlog_Internalname, StringUtil.RTrim( A15AmGeusrlog), StringUtil.RTrim( context.localUtil.Format( A15AmGeusrlog, "99999")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAmGeusrlog_Jsonclick, 0, "", "", "", "", "", 1, edtAmGeusrlog_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 0, -1, -1, true, "codmediano", "left", true, "", "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAmGefeclog_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAmGefeclog_Internalname, "AmGefeclog", "col-sm-3 ", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
         context.WriteHtmlText( "<div id=\""+edtAmGefeclog_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
         GxWebStd.gx_single_line_edit( context, edtAmGefeclog_Internalname, context.localUtil.Format(A16AmGefeclog, "99/99/9999"), context.localUtil.Format( A16AmGefeclog, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,82);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAmGefeclog_Jsonclick, 0, "", "", "", "", "", 1, edtAmGefeclog_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 0, -1, 0, true, "fecha2000", "right", false, "", "HLP_TagAmGe.htm");
         GxWebStd.gx_bitmap( context, edtAmGefeclog_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtAmGefeclog_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_TagAmGe.htm");
         context.WriteHtmlTextNl( "</div>") ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAmGehralog_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAmGehralog_Internalname, "AmGehralog", "col-sm-3 ", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAmGehralog_Internalname, StringUtil.RTrim( A17AmGehralog), StringUtil.RTrim( context.localUtil.Format( A17AmGehralog, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,87);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAmGehralog_Jsonclick, 0, "", "", "", "", "", 1, edtAmGehralog_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 0, -1, -1, true, "hora", "left", true, "", "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "middle", "", "", "div");
         gxdraw_Grid1( ) ;
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         gxdraw_Grid2( ) ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         gxdraw_Grid3( ) ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         gxdraw_Grid4( ) ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTable5_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 125,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_check_Internalname, "", "Verificar", bttBtn_check_Jsonclick, 5, "Verificar", "", StyleString, ClassString, bttBtn_check_Visible, bttBtn_check_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"ECHECK."+"'", TempTags, "", context.GetButtonType( ), "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 128,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 131,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 134,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_help_Internalname, "", "Ayuda", bttBtn_help_Jsonclick, 3, "Ayuda", "", StyleString, ClassString, bttBtn_help_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EHELP."+"'", TempTags, "", 2, "HLP_TagAmGe.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "middle", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
      }

      protected void gxdraw_Grid1( )
      {
         /*  Grid Control  */
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("Header", subGrid1_Header);
         Grid1Container.AddObjectProperty("Class", "");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_4), 4, 0, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavnRcdDeleted_4_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A5AmGeSec));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmGeSec_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A30AmGeMail));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmGeMail_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
         nGXsfl_91_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount4 = 5;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_4 = 1;
               ScanStart014( ) ;
               while ( RcdFound4 != 0 )
               {
                  init_level_properties4( ) ;
                  getByPrimaryKey014( ) ;
                  AddRow014( ) ;
                  ScanNext014( ) ;
               }
               ScanEnd014( ) ;
               nBlankRcdCount4 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal014( ) ;
            standaloneModal014( ) ;
            sMode4 = Gx_mode;
            while ( nGXsfl_91_idx < nRC_GXsfl_91 )
            {
               bGXsfl_91_Refreshing = true;
               ReadRow014( ) ;
               edtavnRcdDeleted_4_Enabled = (int)(context.localUtil.CToN( cgiGet( "vNRCDDELETED_4_"+sGXsfl_91_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtavnRcdDeleted_4_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavnRcdDeleted_4_Enabled), 5, 0), !bGXsfl_91_Refreshing);
               edtAmGeSec_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGESEC_"+sGXsfl_91_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmGeSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeSec_Enabled), 5, 0), !bGXsfl_91_Refreshing);
               edtAmGeMail_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEMAIL_"+sGXsfl_91_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmGeMail_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeMail_Enabled), 5, 0), !bGXsfl_91_Refreshing);
               if ( ( nRcdExists_4 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  standaloneModal014( ) ;
               }
               SendRow014( ) ;
               bGXsfl_91_Refreshing = false;
            }
            Gx_mode = sMode4;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount4 = 5;
            nRcdExists_4 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart014( ) ;
               while ( RcdFound4 != 0 )
               {
                  sGXsfl_91_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_91_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_914( ) ;
                  init_level_properties4( ) ;
                  standaloneNotModal014( ) ;
                  getByPrimaryKey014( ) ;
                  standaloneModal014( ) ;
                  AddRow014( ) ;
                  ScanNext014( ) ;
               }
               ScanEnd014( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode4 = Gx_mode;
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sGXsfl_91_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_91_idx+1), 4, 0), 4, "0");
         SubsflControlProps_914( ) ;
         InitAll014( ) ;
         init_level_properties4( ) ;
         nRcdExists_4 = 0;
         nIsMod_4 = 0;
         nRcdDeleted_4 = 0;
         nBlankRcdCount4 = (short)(nBlankRcdUsr4+nBlankRcdCount4);
         fRowAdded = 0;
         while ( nBlankRcdCount4 > 0 )
         {
            standaloneNotModal014( ) ;
            standaloneModal014( ) ;
            AddRow014( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtAmGeSec_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount4 = (short)(nBlankRcdCount4-1);
         }
         Gx_mode = sMode4;
         AssignAttri("", false, "Gx_mode", Gx_mode);
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

      protected void gxdraw_Grid2( )
      {
         /*  Grid Control  */
         Grid2Container.AddObjectProperty("GridName", "Grid2");
         Grid2Container.AddObjectProperty("Header", subGrid2_Header);
         Grid2Container.AddObjectProperty("Class", "Grid");
         Grid2Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid2Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid2Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Backcolorstyle), 1, 0, ".", "")));
         Grid2Container.AddObjectProperty("CmpContext", "");
         Grid2Container.AddObjectProperty("InMasterPage", "false");
         Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid2Column.AddObjectProperty("Value", StringUtil.RTrim( A4AmgeSec2));
         Grid2Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeSec2_Enabled), 5, 0, ".", "")));
         Grid2Container.AddColumnProperties(Grid2Column);
         Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid2Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27AmgeNoPesIni), 4, 0, ".", "")));
         Grid2Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeNoPesIni_Enabled), 5, 0, ".", "")));
         Grid2Container.AddColumnProperties(Grid2Column);
         Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid2Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A28AmgeNoPesTer), 4, 0, ".", "")));
         Grid2Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeNoPesTer_Enabled), 5, 0, ".", "")));
         Grid2Container.AddColumnProperties(Grid2Column);
         Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid2Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A29AmgeValPago, 9, 2, ".", "")));
         Grid2Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeValPago_Enabled), 5, 0, ".", "")));
         Grid2Container.AddColumnProperties(Grid2Column);
         Grid2Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Selectedindex), 4, 0, ".", "")));
         Grid2Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Allowselection), 1, 0, ".", "")));
         Grid2Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Selectioncolor), 9, 0, ".", "")));
         Grid2Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Allowhovering), 1, 0, ".", "")));
         Grid2Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Hoveringcolor), 9, 0, ".", "")));
         Grid2Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Allowcollapsing), 1, 0, ".", "")));
         Grid2Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Collapsed), 1, 0, ".", "")));
         nGXsfl_97_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount3 = 5;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_3 = 1;
               ScanStart013( ) ;
               while ( RcdFound3 != 0 )
               {
                  init_level_properties3( ) ;
                  getByPrimaryKey013( ) ;
                  AddRow013( ) ;
                  ScanNext013( ) ;
               }
               ScanEnd013( ) ;
               nBlankRcdCount3 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal013( ) ;
            standaloneModal013( ) ;
            sMode3 = Gx_mode;
            while ( nGXsfl_97_idx < nRC_GXsfl_97 )
            {
               bGXsfl_97_Refreshing = true;
               ReadRow013( ) ;
               edtAmgeSec2_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGESEC2_"+sGXsfl_97_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmgeSec2_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeSec2_Enabled), 5, 0), !bGXsfl_97_Refreshing);
               edtAmgeNoPesIni_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGENOPESINI_"+sGXsfl_97_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmgeNoPesIni_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeNoPesIni_Enabled), 5, 0), !bGXsfl_97_Refreshing);
               edtAmgeNoPesTer_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGENOPESTER_"+sGXsfl_97_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmgeNoPesTer_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeNoPesTer_Enabled), 5, 0), !bGXsfl_97_Refreshing);
               edtAmgeValPago_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEVALPAGO_"+sGXsfl_97_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmgeValPago_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeValPago_Enabled), 5, 0), !bGXsfl_97_Refreshing);
               if ( ( nRcdExists_3 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  standaloneModal013( ) ;
               }
               SendRow013( ) ;
               bGXsfl_97_Refreshing = false;
            }
            Gx_mode = sMode3;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount3 = 5;
            nRcdExists_3 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart013( ) ;
               while ( RcdFound3 != 0 )
               {
                  sGXsfl_97_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_97_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_973( ) ;
                  init_level_properties3( ) ;
                  standaloneNotModal013( ) ;
                  getByPrimaryKey013( ) ;
                  standaloneModal013( ) ;
                  AddRow013( ) ;
                  ScanNext013( ) ;
               }
               ScanEnd013( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode3 = Gx_mode;
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sGXsfl_97_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_97_idx+1), 4, 0), 4, "0");
         SubsflControlProps_973( ) ;
         InitAll013( ) ;
         init_level_properties3( ) ;
         nRcdExists_3 = 0;
         nIsMod_3 = 0;
         nRcdDeleted_3 = 0;
         nBlankRcdCount3 = (short)(nBlankRcdUsr3+nBlankRcdCount3);
         fRowAdded = 0;
         while ( nBlankRcdCount3 > 0 )
         {
            standaloneNotModal013( ) ;
            standaloneModal013( ) ;
            AddRow013( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtAmgeSec2_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount3 = (short)(nBlankRcdCount3-1);
         }
         Gx_mode = sMode3;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Grid2Container"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid2", Grid2Container);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Grid2ContainerData", Grid2Container.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Grid2ContainerData"+"V", Grid2Container.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid2ContainerData"+"V"+"\" value='"+Grid2Container.GridValuesHidden()+"'/>") ;
         }
      }

      protected void gxdraw_Grid3( )
      {
         /*  Grid Control  */
         Grid3Container.AddObjectProperty("GridName", "Grid3");
         Grid3Container.AddObjectProperty("Header", subGrid3_Header);
         Grid3Container.AddObjectProperty("Class", "Grid");
         Grid3Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid3Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid3Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid3_Backcolorstyle), 1, 0, ".", "")));
         Grid3Container.AddObjectProperty("CmpContext", "");
         Grid3Container.AddObjectProperty("InMasterPage", "false");
         Grid3Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid3Column.AddObjectProperty("Value", StringUtil.RTrim( A3AmgewsSec));
         Grid3Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgewsSec_Enabled), 5, 0, ".", "")));
         Grid3Container.AddColumnProperties(Grid3Column);
         Grid3Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid3Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A21AmgeWsPort), 4, 0, ".", "")));
         Grid3Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsPort_Enabled), 5, 0, ".", "")));
         Grid3Container.AddColumnProperties(Grid3Column);
         Grid3Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid3Column.AddObjectProperty("Value", StringUtil.RTrim( A22AmgeWsHost));
         Grid3Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsHost_Enabled), 5, 0, ".", "")));
         Grid3Container.AddColumnProperties(Grid3Column);
         Grid3Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid3Column.AddObjectProperty("Value", A23AmgeWsUri);
         Grid3Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsUri_Enabled), 5, 0, ".", "")));
         Grid3Container.AddColumnProperties(Grid3Column);
         Grid3Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid3Column.AddObjectProperty("Value", StringUtil.RTrim( A24AmgeWsLoc));
         Grid3Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsLoc_Enabled), 5, 0, ".", "")));
         Grid3Container.AddColumnProperties(Grid3Column);
         Grid3Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid3Column.AddObjectProperty("Value", StringUtil.RTrim( A25AmgeWsTip));
         Grid3Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsTip_Enabled), 5, 0, ".", "")));
         Grid3Container.AddColumnProperties(Grid3Column);
         Grid3Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid3Column.AddObjectProperty("Value", StringUtil.RTrim( A26AmgeWsEst));
         Grid3Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsEst_Enabled), 5, 0, ".", "")));
         Grid3Container.AddColumnProperties(Grid3Column);
         Grid3Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid3_Selectedindex), 4, 0, ".", "")));
         Grid3Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid3_Allowselection), 1, 0, ".", "")));
         Grid3Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid3_Selectioncolor), 9, 0, ".", "")));
         Grid3Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid3_Allowhovering), 1, 0, ".", "")));
         Grid3Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid3_Hoveringcolor), 9, 0, ".", "")));
         Grid3Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid3_Allowcollapsing), 1, 0, ".", "")));
         Grid3Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid3_Collapsed), 1, 0, ".", "")));
         nGXsfl_104_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount2 = 5;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_2 = 1;
               ScanStart012( ) ;
               while ( RcdFound2 != 0 )
               {
                  init_level_properties2( ) ;
                  getByPrimaryKey012( ) ;
                  AddRow012( ) ;
                  ScanNext012( ) ;
               }
               ScanEnd012( ) ;
               nBlankRcdCount2 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal012( ) ;
            standaloneModal012( ) ;
            sMode2 = Gx_mode;
            while ( nGXsfl_104_idx < nRC_GXsfl_104 )
            {
               bGXsfl_104_Refreshing = true;
               ReadRow012( ) ;
               edtAmgewsSec_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSSEC_"+sGXsfl_104_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmgewsSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgewsSec_Enabled), 5, 0), !bGXsfl_104_Refreshing);
               edtAmgeWsPort_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSPORT_"+sGXsfl_104_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmgeWsPort_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeWsPort_Enabled), 5, 0), !bGXsfl_104_Refreshing);
               edtAmgeWsHost_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSHOST_"+sGXsfl_104_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmgeWsHost_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeWsHost_Enabled), 5, 0), !bGXsfl_104_Refreshing);
               edtAmgeWsUri_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSURI_"+sGXsfl_104_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmgeWsUri_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeWsUri_Enabled), 5, 0), !bGXsfl_104_Refreshing);
               edtAmgeWsLoc_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSLOC_"+sGXsfl_104_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmgeWsLoc_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeWsLoc_Enabled), 5, 0), !bGXsfl_104_Refreshing);
               edtAmgeWsTip_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSTIP_"+sGXsfl_104_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmgeWsTip_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeWsTip_Enabled), 5, 0), !bGXsfl_104_Refreshing);
               edtAmgeWsEst_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSEST_"+sGXsfl_104_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmgeWsEst_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeWsEst_Enabled), 5, 0), !bGXsfl_104_Refreshing);
               if ( ( nRcdExists_2 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  standaloneModal012( ) ;
               }
               SendRow012( ) ;
               bGXsfl_104_Refreshing = false;
            }
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount2 = 5;
            nRcdExists_2 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart012( ) ;
               while ( RcdFound2 != 0 )
               {
                  sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_104_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_1042( ) ;
                  init_level_properties2( ) ;
                  standaloneNotModal012( ) ;
                  getByPrimaryKey012( ) ;
                  standaloneModal012( ) ;
                  AddRow012( ) ;
                  ScanNext012( ) ;
               }
               ScanEnd012( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode2 = Gx_mode;
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_104_idx+1), 4, 0), 4, "0");
         SubsflControlProps_1042( ) ;
         InitAll012( ) ;
         init_level_properties2( ) ;
         nRcdExists_2 = 0;
         nIsMod_2 = 0;
         nRcdDeleted_2 = 0;
         nBlankRcdCount2 = (short)(nBlankRcdUsr2+nBlankRcdCount2);
         fRowAdded = 0;
         while ( nBlankRcdCount2 > 0 )
         {
            standaloneNotModal012( ) ;
            standaloneModal012( ) ;
            AddRow012( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtAmgewsSec_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount2 = (short)(nBlankRcdCount2-1);
         }
         Gx_mode = sMode2;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Grid3Container"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid3", Grid3Container);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Grid3ContainerData", Grid3Container.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Grid3ContainerData"+"V", Grid3Container.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid3ContainerData"+"V"+"\" value='"+Grid3Container.GridValuesHidden()+"'/>") ;
         }
      }

      protected void gxdraw_Grid4( )
      {
         /*  Grid Control  */
         Grid4Container.AddObjectProperty("GridName", "Grid4");
         Grid4Container.AddObjectProperty("Header", subGrid4_Header);
         Grid4Container.AddObjectProperty("Class", "Grid");
         Grid4Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid4Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid4Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid4_Backcolorstyle), 1, 0, ".", "")));
         Grid4Container.AddObjectProperty("CmpContext", "");
         Grid4Container.AddObjectProperty("InMasterPage", "false");
         Grid4Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid4Column.AddObjectProperty("Value", StringUtil.RTrim( A43AmGeMailSec));
         Grid4Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmGeMailSec_Enabled), 5, 0, ".", "")));
         Grid4Container.AddColumnProperties(Grid4Column);
         Grid4Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid4Column.AddObjectProperty("Value", StringUtil.BoolToStr( A50AmgeMailSecure));
         Grid4Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkAmgeMailSecure.Enabled), 5, 0, ".", "")));
         Grid4Container.AddColumnProperties(Grid4Column);
         Grid4Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid4_Selectedindex), 4, 0, ".", "")));
         Grid4Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid4_Allowselection), 1, 0, ".", "")));
         Grid4Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid4_Selectioncolor), 9, 0, ".", "")));
         Grid4Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid4_Allowhovering), 1, 0, ".", "")));
         Grid4Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid4_Hoveringcolor), 9, 0, ".", "")));
         Grid4Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid4_Allowcollapsing), 1, 0, ".", "")));
         Grid4Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid4_Collapsed), 1, 0, ".", "")));
         nGXsfl_114_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount6 = 5;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_6 = 1;
               ScanStart016( ) ;
               while ( RcdFound6 != 0 )
               {
                  init_level_properties6( ) ;
                  getByPrimaryKey016( ) ;
                  AddRow016( ) ;
                  ScanNext016( ) ;
               }
               ScanEnd016( ) ;
               nBlankRcdCount6 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal016( ) ;
            standaloneModal016( ) ;
            sMode6 = Gx_mode;
            while ( nGXsfl_114_idx < nRC_GXsfl_114 )
            {
               bGXsfl_114_Refreshing = true;
               ReadRow016( ) ;
               edtAmGeMailSec_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEMAILSEC_"+sGXsfl_114_idx+"Enabled"), ",", "."));
               AssignProp("", false, edtAmGeMailSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeMailSec_Enabled), 5, 0), !bGXsfl_114_Refreshing);
               chkAmgeMailSecure.Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEMAILSECURE_"+sGXsfl_114_idx+"Enabled"), ",", "."));
               AssignProp("", false, chkAmgeMailSecure_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkAmgeMailSecure.Enabled), 5, 0), !bGXsfl_114_Refreshing);
               if ( ( nRcdExists_6 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  standaloneModal016( ) ;
               }
               SendRow016( ) ;
               bGXsfl_114_Refreshing = false;
            }
            Gx_mode = sMode6;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount6 = 5;
            nRcdExists_6 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart016( ) ;
               while ( RcdFound6 != 0 )
               {
                  sGXsfl_114_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_114_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_1146( ) ;
                  init_level_properties6( ) ;
                  standaloneNotModal016( ) ;
                  getByPrimaryKey016( ) ;
                  standaloneModal016( ) ;
                  AddRow016( ) ;
                  ScanNext016( ) ;
               }
               ScanEnd016( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode6 = Gx_mode;
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sGXsfl_114_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_114_idx+1), 4, 0), 4, "0");
         SubsflControlProps_1146( ) ;
         InitAll016( ) ;
         init_level_properties6( ) ;
         nRcdExists_6 = 0;
         nIsMod_6 = 0;
         nRcdDeleted_6 = 0;
         nBlankRcdCount6 = (short)(nBlankRcdUsr6+nBlankRcdCount6);
         fRowAdded = 0;
         while ( nBlankRcdCount6 > 0 )
         {
            standaloneNotModal016( ) ;
            standaloneModal016( ) ;
            AddRow016( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtAmGeMailSec_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount6 = (short)(nBlankRcdCount6-1);
         }
         Gx_mode = sMode6;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Grid4Container"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid4", Grid4Container);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Grid4ContainerData", Grid4Container.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Grid4ContainerData"+"V", Grid4Container.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid4ContainerData"+"V"+"\" value='"+Grid4Container.GridValuesHidden()+"'/>") ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            Z1AmGecod = cgiGet( "Z1AmGecod");
            Z7AmGedes = cgiGet( "Z7AmGedes");
            n7AmGedes = (String.IsNullOrEmpty(StringUtil.RTrim( A7AmGedes)) ? true : false);
            Z11AmGeval = (long)(context.localUtil.CToN( cgiGet( "Z11AmGeval"), ",", "."));
            n11AmGeval = ((0==A11AmGeval) ? true : false);
            Z12AmGedet = cgiGet( "Z12AmGedet");
            n12AmGedet = (String.IsNullOrEmpty(StringUtil.RTrim( A12AmGedet)) ? true : false);
            Z20AmgeAbr = cgiGet( "Z20AmgeAbr");
            n20AmgeAbr = (String.IsNullOrEmpty(StringUtil.RTrim( A20AmgeAbr)) ? true : false);
            Z8AmGesta = cgiGet( "Z8AmGesta");
            n8AmGesta = (String.IsNullOrEmpty(StringUtil.RTrim( A8AmGesta)) ? true : false);
            Z14AmgeAnio = (short)(context.localUtil.CToN( cgiGet( "Z14AmgeAnio"), ",", "."));
            n14AmgeAnio = ((0==A14AmgeAnio) ? true : false);
            Z15AmGeusrlog = cgiGet( "Z15AmGeusrlog");
            n15AmGeusrlog = (String.IsNullOrEmpty(StringUtil.RTrim( A15AmGeusrlog)) ? true : false);
            Z16AmGefeclog = context.localUtil.CToD( cgiGet( "Z16AmGefeclog"), 0);
            n16AmGefeclog = ((DateTime.MinValue==A16AmGefeclog) ? true : false);
            Z17AmGehralog = cgiGet( "Z17AmGehralog");
            n17AmGehralog = (String.IsNullOrEmpty(StringUtil.RTrim( A17AmGehralog)) ? true : false);
            Z9AmgeStaGmail = cgiGet( "Z9AmgeStaGmail");
            n9AmgeStaGmail = (String.IsNullOrEmpty(StringUtil.RTrim( A9AmgeStaGmail)) ? true : false);
            Z10AmGePswEMail = cgiGet( "Z10AmGePswEMail");
            n10AmGePswEMail = (String.IsNullOrEmpty(StringUtil.RTrim( A10AmGePswEMail)) ? true : false);
            Z2AmgeUmedCd = cgiGet( "Z2AmgeUmedCd");
            n2AmgeUmedCd = (String.IsNullOrEmpty(StringUtil.RTrim( A2AmgeUmedCd)) ? true : false);
            A20AmgeAbr = cgiGet( "Z20AmgeAbr");
            n20AmgeAbr = false;
            n20AmgeAbr = (String.IsNullOrEmpty(StringUtil.RTrim( A20AmgeAbr)) ? true : false);
            A9AmgeStaGmail = cgiGet( "Z9AmgeStaGmail");
            n9AmgeStaGmail = false;
            n9AmgeStaGmail = (String.IsNullOrEmpty(StringUtil.RTrim( A9AmgeStaGmail)) ? true : false);
            A10AmGePswEMail = cgiGet( "Z10AmGePswEMail");
            n10AmGePswEMail = false;
            n10AmGePswEMail = (String.IsNullOrEmpty(StringUtil.RTrim( A10AmGePswEMail)) ? true : false);
            A2AmgeUmedCd = cgiGet( "Z2AmgeUmedCd");
            n2AmgeUmedCd = false;
            n2AmgeUmedCd = (String.IsNullOrEmpty(StringUtil.RTrim( A2AmgeUmedCd)) ? true : false);
            IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
            IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
            Gx_mode = cgiGet( "Mode");
            nRC_GXsfl_104 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_104"), ",", "."));
            nRC_GXsfl_97 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_97"), ",", "."));
            nRC_GXsfl_91 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_91"), ",", "."));
            nRC_GXsfl_114 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_114"), ",", "."));
            A20AmgeAbr = cgiGet( "AMGEABR");
            n20AmgeAbr = (String.IsNullOrEmpty(StringUtil.RTrim( A20AmgeAbr)) ? true : false);
            A9AmgeStaGmail = cgiGet( "AMGESTAGMAIL");
            n9AmgeStaGmail = (String.IsNullOrEmpty(StringUtil.RTrim( A9AmgeStaGmail)) ? true : false);
            A10AmGePswEMail = cgiGet( "AMGEPSWEMAIL");
            n10AmGePswEMail = (String.IsNullOrEmpty(StringUtil.RTrim( A10AmGePswEMail)) ? true : false);
            A2AmgeUmedCd = cgiGet( "AMGEUMEDCD");
            n2AmgeUmedCd = (String.IsNullOrEmpty(StringUtil.RTrim( A2AmgeUmedCd)) ? true : false);
            A18AmgeUmedDs = cgiGet( "AMGEUMEDDS");
            A44AmGeMailPort = (short)(context.localUtil.CToN( cgiGet( "AMGEMAILPORT"), ",", "."));
            A45AmGeMailHost = cgiGet( "AMGEMAILHOST");
            A46AmGeMailSender = cgiGet( "AMGEMAILSENDER");
            A47AmgeMailUser = cgiGet( "AMGEMAILUSER");
            A48AmgeMailPassword = cgiGet( "AMGEMAILPASSWORD");
            A49AmgeMailAuthentication = StringUtil.StrToBool( cgiGet( "AMGEMAILAUTHENTICATION"));
            A51AmgeMailEstado = cgiGet( "AMGEMAILESTADO");
            /* Read variables values. */
            A1AmGecod = cgiGet( edtAmGecod_Internalname);
            AssignAttri("", false, "A1AmGecod", A1AmGecod);
            A7AmGedes = StringUtil.Upper( cgiGet( edtAmGedes_Internalname));
            n7AmGedes = false;
            AssignAttri("", false, "A7AmGedes", A7AmGedes);
            n7AmGedes = (String.IsNullOrEmpty(StringUtil.RTrim( A7AmGedes)) ? true : false);
            if ( ( ( context.localUtil.CToN( cgiGet( edtAmGeval_Internalname), ",", ".") < Convert.ToDecimal( -999999999L )) ) || ( ( context.localUtil.CToN( cgiGet( edtAmGeval_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "AMGEVAL");
               AnyError = 1;
               GX_FocusControl = edtAmGeval_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A11AmGeval = 0;
               n11AmGeval = false;
               AssignAttri("", false, "A11AmGeval", StringUtil.LTrimStr( (decimal)(A11AmGeval), 10, 0));
            }
            else
            {
               A11AmGeval = (long)(context.localUtil.CToN( cgiGet( edtAmGeval_Internalname), ",", "."));
               n11AmGeval = false;
               AssignAttri("", false, "A11AmGeval", StringUtil.LTrimStr( (decimal)(A11AmGeval), 10, 0));
            }
            n11AmGeval = ((0==A11AmGeval) ? true : false);
            A12AmGedet = StringUtil.Upper( cgiGet( edtAmGedet_Internalname));
            n12AmGedet = false;
            AssignAttri("", false, "A12AmGedet", A12AmGedet);
            n12AmGedet = (String.IsNullOrEmpty(StringUtil.RTrim( A12AmGedet)) ? true : false);
            A8AmGesta = cgiGet( edtAmGesta_Internalname);
            n8AmGesta = false;
            AssignAttri("", false, "A8AmGesta", A8AmGesta);
            n8AmGesta = (String.IsNullOrEmpty(StringUtil.RTrim( A8AmGesta)) ? true : false);
            A13AmGeobs = cgiGet( edtAmGeobs_Internalname);
            n13AmGeobs = false;
            AssignAttri("", false, "A13AmGeobs", A13AmGeobs);
            n13AmGeobs = (String.IsNullOrEmpty(StringUtil.RTrim( A13AmGeobs)) ? true : false);
            if ( ( ( context.localUtil.CToN( cgiGet( edtAmgeAnio_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAmgeAnio_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "AMGEANIO");
               AnyError = 1;
               GX_FocusControl = edtAmgeAnio_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A14AmgeAnio = 0;
               n14AmgeAnio = false;
               AssignAttri("", false, "A14AmgeAnio", StringUtil.LTrimStr( (decimal)(A14AmgeAnio), 4, 0));
            }
            else
            {
               A14AmgeAnio = (short)(context.localUtil.CToN( cgiGet( edtAmgeAnio_Internalname), ",", "."));
               n14AmgeAnio = false;
               AssignAttri("", false, "A14AmgeAnio", StringUtil.LTrimStr( (decimal)(A14AmgeAnio), 4, 0));
            }
            n14AmgeAnio = ((0==A14AmgeAnio) ? true : false);
            A15AmGeusrlog = cgiGet( edtAmGeusrlog_Internalname);
            n15AmGeusrlog = false;
            AssignAttri("", false, "A15AmGeusrlog", A15AmGeusrlog);
            n15AmGeusrlog = (String.IsNullOrEmpty(StringUtil.RTrim( A15AmGeusrlog)) ? true : false);
            if ( context.localUtil.VCDate( cgiGet( edtAmGefeclog_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"AmGefeclog"}), 1, "AMGEFECLOG");
               AnyError = 1;
               GX_FocusControl = edtAmGefeclog_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A16AmGefeclog = DateTime.MinValue;
               n16AmGefeclog = false;
               AssignAttri("", false, "A16AmGefeclog", context.localUtil.Format(A16AmGefeclog, "99/99/9999"));
            }
            else
            {
               A16AmGefeclog = context.localUtil.CToD( cgiGet( edtAmGefeclog_Internalname), 2);
               n16AmGefeclog = false;
               AssignAttri("", false, "A16AmGefeclog", context.localUtil.Format(A16AmGefeclog, "99/99/9999"));
            }
            n16AmGefeclog = ((DateTime.MinValue==A16AmGefeclog) ? true : false);
            A17AmGehralog = cgiGet( edtAmGehralog_Internalname);
            n17AmGehralog = false;
            AssignAttri("", false, "A17AmGehralog", A17AmGehralog);
            n17AmGehralog = (String.IsNullOrEmpty(StringUtil.RTrim( A17AmGehralog)) ? true : false);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = new GXProperties();
            forbiddenHiddens.Add("hshsalt", "hsh"+"TagAmGe");
            forbiddenHiddens.Add("AmgeAbr", StringUtil.RTrim( context.localUtil.Format( A20AmgeAbr, "")));
            forbiddenHiddens.Add("AmgeUmedCd", StringUtil.RTrim( context.localUtil.Format( A2AmgeUmedCd, "99999")));
            forbiddenHiddens.Add("AmgeStaGmail", StringUtil.RTrim( context.localUtil.Format( A9AmgeStaGmail, "!")));
            forbiddenHiddens.Add("AmGePswEMail", StringUtil.RTrim( context.localUtil.Format( A10AmGePswEMail, "@!")));
            hsh = cgiGet( "hsh");
            if ( ( ! ( ( StringUtil.StrCmp(A1AmGecod, Z1AmGecod) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
            {
               GXUtil.WriteLogError("tagamge:[ SecurityCheckFailed (403 Forbidden) value for]"+forbiddenHiddens.ToJSonString());
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               AnyError = 1;
               return  ;
            }
            /* Check if conditions changed and reset current page numbers */
            /* Check if conditions changed and reset current page numbers */
            /* Check if conditions changed and reset current page numbers */
            /* Check if conditions changed and reset current page numbers */
            standaloneNotModal( ) ;
         }
         else
         {
            standaloneNotModal( ) ;
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
            {
               Gx_mode = "DSP";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               A1AmGecod = GetNextPar( );
               AssignAttri("", false, "A1AmGecod", A1AmGecod);
               getEqualNoModal( ) ;
               Gx_mode = "DSP";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               disable_std_buttons_dsp( ) ;
               standaloneModal( ) ;
            }
            else
            {
               Gx_mode = "INS";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               standaloneModal( ) ;
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GET") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_get( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "CHECK") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_Check( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_delete( ) ;
                           /* No code required for Help button. It is implemented at the Browser level. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           AfterKeyLoadScreen( ) ;
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( endTrnMsgTxt)) )
            {
               GX_msglist.addItem(endTrnMsgTxt, endTrnMsgCod, 0, "", true);
            }
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll011( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
         endTrnMsgTxt = "";
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         if ( IsIns( ) )
         {
            bttBtn_delete_Enabled = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
         AssignProp("", false, edtavnRcdDeleted_4_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavnRcdDeleted_4_Enabled), 5, 0), !bGXsfl_91_Refreshing);
      }

      protected void disable_std_buttons_dsp( )
      {
         bttBtn_delete_Visible = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
         bttBtn_first_Visible = 0;
         AssignProp("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_first_Visible), 5, 0), true);
         bttBtn_previous_Visible = 0;
         AssignProp("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_previous_Visible), 5, 0), true);
         bttBtn_next_Visible = 0;
         AssignProp("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_next_Visible), 5, 0), true);
         bttBtn_last_Visible = 0;
         AssignProp("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_last_Visible), 5, 0), true);
         bttBtn_select_Visible = 0;
         AssignProp("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_select_Visible), 5, 0), true);
         bttBtn_get_Visible = 0;
         AssignProp("", false, bttBtn_get_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_get_Visible), 5, 0), true);
         bttBtn_delete_Visible = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
         if ( IsDsp( ) )
         {
            bttBtn_enter_Visible = 0;
            AssignProp("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Visible), 5, 0), true);
         }
         DisableAttributes011( ) ;
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( IsDlt( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               if ( AnyError == 0 )
               {
                  ZM011( 3) ;
               }
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode1 = Gx_mode;
            CONFIRM_012( ) ;
            if ( AnyError == 0 )
            {
               CONFIRM_013( ) ;
               if ( AnyError == 0 )
               {
                  CONFIRM_014( ) ;
                  if ( AnyError == 0 )
                  {
                     CONFIRM_016( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Restore parent mode. */
                        Gx_mode = sMode1;
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        IsConfirmed = 1;
                        AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                     }
                  }
               }
            }
            /* Restore parent mode. */
            Gx_mode = sMode1;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         if ( AnyError == 0 )
         {
            ConfirmValues010( ) ;
         }
      }

      protected void CONFIRM_016( )
      {
         nGXsfl_114_idx = 0;
         while ( nGXsfl_114_idx < nRC_GXsfl_114 )
         {
            ReadRow016( ) ;
            if ( ( nRcdExists_6 != 0 ) || ( nIsMod_6 != 0 ) )
            {
               GetKey016( ) ;
               if ( ( nRcdExists_6 == 0 ) && ( nRcdDeleted_6 == 0 ) )
               {
                  if ( RcdFound6 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate016( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable016( ) ;
                        if ( AnyError == 0 )
                        {
                        }
                        CloseExtendedTableCursors016( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "AMGEMAILSEC_" + sGXsfl_114_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtAmGeMailSec_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound6 != 0 )
                  {
                     if ( nRcdDeleted_6 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey016( ) ;
                        Load016( ) ;
                        BeforeValidate016( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls016( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_6 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate016( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable016( ) ;
                              if ( AnyError == 0 )
                              {
                              }
                              CloseExtendedTableCursors016( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_6 == 0 )
                     {
                        GXCCtl = "AMGEMAILSEC_" + sGXsfl_114_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtAmGeMailSec_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtAmGeMailSec_Internalname, StringUtil.RTrim( A43AmGeMailSec)) ;
            ChangePostValue( chkAmgeMailSecure_Internalname, StringUtil.BoolToStr( A50AmgeMailSecure)) ;
            ChangePostValue( "ZT_"+"Z43AmGeMailSec_"+sGXsfl_114_idx, StringUtil.RTrim( Z43AmGeMailSec)) ;
            ChangePostValue( "ZT_"+"Z44AmGeMailPort_"+sGXsfl_114_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z44AmGeMailPort), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z45AmGeMailHost_"+sGXsfl_114_idx, Z45AmGeMailHost) ;
            ChangePostValue( "ZT_"+"Z46AmGeMailSender_"+sGXsfl_114_idx, Z46AmGeMailSender) ;
            ChangePostValue( "ZT_"+"Z47AmgeMailUser_"+sGXsfl_114_idx, Z47AmgeMailUser) ;
            ChangePostValue( "ZT_"+"Z48AmgeMailPassword_"+sGXsfl_114_idx, Z48AmgeMailPassword) ;
            ChangePostValue( "ZT_"+"Z49AmgeMailAuthentication_"+sGXsfl_114_idx, StringUtil.BoolToStr( Z49AmgeMailAuthentication)) ;
            ChangePostValue( "ZT_"+"Z50AmgeMailSecure_"+sGXsfl_114_idx, StringUtil.BoolToStr( Z50AmgeMailSecure)) ;
            ChangePostValue( "ZT_"+"Z51AmgeMailEstado_"+sGXsfl_114_idx, StringUtil.RTrim( Z51AmgeMailEstado)) ;
            ChangePostValue( "nRcdDeleted_6_"+sGXsfl_114_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_6), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_6_"+sGXsfl_114_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_6), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_6_"+sGXsfl_114_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_6), 4, 0, ",", ""))) ;
            if ( nIsMod_6 != 0 )
            {
               ChangePostValue( "AMGEMAILSEC_"+sGXsfl_114_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmGeMailSec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEMAILSECURE_"+sGXsfl_114_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkAmgeMailSecure.Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void CONFIRM_014( )
      {
         nGXsfl_91_idx = 0;
         while ( nGXsfl_91_idx < nRC_GXsfl_91 )
         {
            ReadRow014( ) ;
            if ( ( nRcdExists_4 != 0 ) || ( nIsMod_4 != 0 ) )
            {
               GetKey014( ) ;
               if ( ( nRcdExists_4 == 0 ) && ( nRcdDeleted_4 == 0 ) )
               {
                  if ( RcdFound4 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate014( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable014( ) ;
                        if ( AnyError == 0 )
                        {
                        }
                        CloseExtendedTableCursors014( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "AMGESEC_" + sGXsfl_91_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtAmGeSec_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound4 != 0 )
                  {
                     if ( nRcdDeleted_4 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey014( ) ;
                        Load014( ) ;
                        BeforeValidate014( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls014( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_4 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate014( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable014( ) ;
                              if ( AnyError == 0 )
                              {
                              }
                              CloseExtendedTableCursors014( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_4 == 0 )
                     {
                        GXCCtl = "AMGESEC_" + sGXsfl_91_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtAmGeSec_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtavnRcdDeleted_4_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_4), 4, 0, ",", ""))) ;
            ChangePostValue( edtAmGeSec_Internalname, StringUtil.RTrim( A5AmGeSec)) ;
            ChangePostValue( edtAmGeMail_Internalname, StringUtil.RTrim( A30AmGeMail)) ;
            ChangePostValue( "ZT_"+"Z5AmGeSec_"+sGXsfl_91_idx, StringUtil.RTrim( Z5AmGeSec)) ;
            ChangePostValue( "ZT_"+"Z30AmGeMail_"+sGXsfl_91_idx, StringUtil.RTrim( Z30AmGeMail)) ;
            ChangePostValue( "nRcdDeleted_4_"+sGXsfl_91_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_4), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_4_"+sGXsfl_91_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_4), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_4_"+sGXsfl_91_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_4), 4, 0, ",", ""))) ;
            if ( nIsMod_4 != 0 )
            {
               ChangePostValue( "vNRCDDELETED_4_"+sGXsfl_91_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavnRcdDeleted_4_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGESEC_"+sGXsfl_91_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmGeSec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEMAIL_"+sGXsfl_91_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmGeMail_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void CONFIRM_013( )
      {
         nGXsfl_97_idx = 0;
         while ( nGXsfl_97_idx < nRC_GXsfl_97 )
         {
            ReadRow013( ) ;
            if ( ( nRcdExists_3 != 0 ) || ( nIsMod_3 != 0 ) )
            {
               GetKey013( ) ;
               if ( ( nRcdExists_3 == 0 ) && ( nRcdDeleted_3 == 0 ) )
               {
                  if ( RcdFound3 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate013( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable013( ) ;
                        if ( AnyError == 0 )
                        {
                        }
                        CloseExtendedTableCursors013( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "AMGESEC2_" + sGXsfl_97_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtAmgeSec2_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound3 != 0 )
                  {
                     if ( nRcdDeleted_3 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey013( ) ;
                        Load013( ) ;
                        BeforeValidate013( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls013( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_3 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate013( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable013( ) ;
                              if ( AnyError == 0 )
                              {
                              }
                              CloseExtendedTableCursors013( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_3 == 0 )
                     {
                        GXCCtl = "AMGESEC2_" + sGXsfl_97_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtAmgeSec2_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtAmgeSec2_Internalname, StringUtil.RTrim( A4AmgeSec2)) ;
            ChangePostValue( edtAmgeNoPesIni_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27AmgeNoPesIni), 4, 0, ",", ""))) ;
            ChangePostValue( edtAmgeNoPesTer_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A28AmgeNoPesTer), 4, 0, ",", ""))) ;
            ChangePostValue( edtAmgeValPago_Internalname, StringUtil.LTrim( StringUtil.NToC( A29AmgeValPago, 9, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z4AmgeSec2_"+sGXsfl_97_idx, StringUtil.RTrim( Z4AmgeSec2)) ;
            ChangePostValue( "ZT_"+"Z27AmgeNoPesIni_"+sGXsfl_97_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27AmgeNoPesIni), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z28AmgeNoPesTer_"+sGXsfl_97_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z28AmgeNoPesTer), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z29AmgeValPago_"+sGXsfl_97_idx, StringUtil.LTrim( StringUtil.NToC( Z29AmgeValPago, 8, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_3_"+sGXsfl_97_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_3), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_3_"+sGXsfl_97_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_3), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_3_"+sGXsfl_97_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_3), 4, 0, ",", ""))) ;
            if ( nIsMod_3 != 0 )
            {
               ChangePostValue( "AMGESEC2_"+sGXsfl_97_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeSec2_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGENOPESINI_"+sGXsfl_97_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeNoPesIni_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGENOPESTER_"+sGXsfl_97_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeNoPesTer_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEVALPAGO_"+sGXsfl_97_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeValPago_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void CONFIRM_012( )
      {
         nGXsfl_104_idx = 0;
         while ( nGXsfl_104_idx < nRC_GXsfl_104 )
         {
            ReadRow012( ) ;
            if ( ( nRcdExists_2 != 0 ) || ( nIsMod_2 != 0 ) )
            {
               GetKey012( ) ;
               if ( ( nRcdExists_2 == 0 ) && ( nRcdDeleted_2 == 0 ) )
               {
                  if ( RcdFound2 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate012( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable012( ) ;
                        if ( AnyError == 0 )
                        {
                        }
                        CloseExtendedTableCursors012( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "AMGEWSSEC_" + sGXsfl_104_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtAmgewsSec_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( nRcdDeleted_2 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey012( ) ;
                        Load012( ) ;
                        BeforeValidate012( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls012( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_2 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate012( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable012( ) ;
                              if ( AnyError == 0 )
                              {
                              }
                              CloseExtendedTableCursors012( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_2 == 0 )
                     {
                        GXCCtl = "AMGEWSSEC_" + sGXsfl_104_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtAmgewsSec_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtAmgewsSec_Internalname, StringUtil.RTrim( A3AmgewsSec)) ;
            ChangePostValue( edtAmgeWsPort_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A21AmgeWsPort), 4, 0, ",", ""))) ;
            ChangePostValue( edtAmgeWsHost_Internalname, StringUtil.RTrim( A22AmgeWsHost)) ;
            ChangePostValue( edtAmgeWsUri_Internalname, A23AmgeWsUri) ;
            ChangePostValue( edtAmgeWsLoc_Internalname, StringUtil.RTrim( A24AmgeWsLoc)) ;
            ChangePostValue( edtAmgeWsTip_Internalname, StringUtil.RTrim( A25AmgeWsTip)) ;
            ChangePostValue( edtAmgeWsEst_Internalname, StringUtil.RTrim( A26AmgeWsEst)) ;
            ChangePostValue( "ZT_"+"Z3AmgewsSec_"+sGXsfl_104_idx, StringUtil.RTrim( Z3AmgewsSec)) ;
            ChangePostValue( "ZT_"+"Z21AmgeWsPort_"+sGXsfl_104_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z21AmgeWsPort), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z22AmgeWsHost_"+sGXsfl_104_idx, StringUtil.RTrim( Z22AmgeWsHost)) ;
            ChangePostValue( "ZT_"+"Z23AmgeWsUri_"+sGXsfl_104_idx, Z23AmgeWsUri) ;
            ChangePostValue( "ZT_"+"Z24AmgeWsLoc_"+sGXsfl_104_idx, StringUtil.RTrim( Z24AmgeWsLoc)) ;
            ChangePostValue( "ZT_"+"Z25AmgeWsTip_"+sGXsfl_104_idx, StringUtil.RTrim( Z25AmgeWsTip)) ;
            ChangePostValue( "ZT_"+"Z26AmgeWsEst_"+sGXsfl_104_idx, StringUtil.RTrim( Z26AmgeWsEst)) ;
            ChangePostValue( "nRcdDeleted_2_"+sGXsfl_104_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_2_"+sGXsfl_104_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_2_"+sGXsfl_104_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ",", ""))) ;
            if ( nIsMod_2 != 0 )
            {
               ChangePostValue( "AMGEWSSEC_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgewsSec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEWSPORT_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsPort_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEWSHOST_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsHost_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEWSURI_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsUri_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEWSLOC_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsLoc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEWSTIP_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsTip_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEWSEST_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsEst_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption010( )
      {
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z7AmGedes = T000111_A7AmGedes[0];
               Z11AmGeval = T000111_A11AmGeval[0];
               Z12AmGedet = T000111_A12AmGedet[0];
               Z20AmgeAbr = T000111_A20AmgeAbr[0];
               Z8AmGesta = T000111_A8AmGesta[0];
               Z14AmgeAnio = T000111_A14AmgeAnio[0];
               Z15AmGeusrlog = T000111_A15AmGeusrlog[0];
               Z16AmGefeclog = T000111_A16AmGefeclog[0];
               Z17AmGehralog = T000111_A17AmGehralog[0];
               Z9AmgeStaGmail = T000111_A9AmgeStaGmail[0];
               Z10AmGePswEMail = T000111_A10AmGePswEMail[0];
               Z2AmgeUmedCd = T000111_A2AmgeUmedCd[0];
            }
            else
            {
               Z7AmGedes = A7AmGedes;
               Z11AmGeval = A11AmGeval;
               Z12AmGedet = A12AmGedet;
               Z20AmgeAbr = A20AmgeAbr;
               Z8AmGesta = A8AmGesta;
               Z14AmgeAnio = A14AmgeAnio;
               Z15AmGeusrlog = A15AmGeusrlog;
               Z16AmGefeclog = A16AmGefeclog;
               Z17AmGehralog = A17AmGehralog;
               Z9AmgeStaGmail = A9AmgeStaGmail;
               Z10AmGePswEMail = A10AmGePswEMail;
               Z2AmgeUmedCd = A2AmgeUmedCd;
            }
         }
         if ( GX_JID == -2 )
         {
            Z1AmGecod = A1AmGecod;
            Z7AmGedes = A7AmGedes;
            Z11AmGeval = A11AmGeval;
            Z12AmGedet = A12AmGedet;
            Z20AmgeAbr = A20AmgeAbr;
            Z8AmGesta = A8AmGesta;
            Z13AmGeobs = A13AmGeobs;
            Z14AmgeAnio = A14AmgeAnio;
            Z15AmGeusrlog = A15AmGeusrlog;
            Z16AmGefeclog = A16AmGefeclog;
            Z17AmGehralog = A17AmGehralog;
            Z9AmgeStaGmail = A9AmgeStaGmail;
            Z10AmGePswEMail = A10AmGePswEMail;
            Z2AmgeUmedCd = A2AmgeUmedCd;
            Z18AmgeUmedDs = A18AmgeUmedDs;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( IsIns( )  )
         {
            bttBtn_get_Enabled = 0;
            AssignProp("", false, bttBtn_get_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_get_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_get_Enabled = 1;
            AssignProp("", false, bttBtn_get_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_get_Enabled), 5, 0), true);
         }
         /* Using cursor T000112 */
         pr_default.execute(10, new Object[] {n2AmgeUmedCd, A2AmgeUmedCd});
         if ( (pr_default.getStatus(10) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A2AmgeUmedCd)) ) )
            {
               GX_msglist.addItem("No existe 'UMedida_Amb General'.", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A18AmgeUmedDs = T000112_A18AmgeUmedDs[0];
         pr_default.close(10);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_check_Enabled = 0;
            AssignProp("", false, bttBtn_check_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_check_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_check_Enabled = 1;
            AssignProp("", false, bttBtn_check_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_check_Enabled), 5, 0), true);
         }
      }

      protected void Load011( )
      {
         /* Using cursor T000113 */
         pr_default.execute(11, new Object[] {A1AmGecod});
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound1 = 1;
            A7AmGedes = T000113_A7AmGedes[0];
            n7AmGedes = T000113_n7AmGedes[0];
            AssignAttri("", false, "A7AmGedes", A7AmGedes);
            A11AmGeval = T000113_A11AmGeval[0];
            n11AmGeval = T000113_n11AmGeval[0];
            AssignAttri("", false, "A11AmGeval", StringUtil.LTrimStr( (decimal)(A11AmGeval), 10, 0));
            A12AmGedet = T000113_A12AmGedet[0];
            n12AmGedet = T000113_n12AmGedet[0];
            AssignAttri("", false, "A12AmGedet", A12AmGedet);
            A20AmgeAbr = T000113_A20AmgeAbr[0];
            n20AmgeAbr = T000113_n20AmgeAbr[0];
            A8AmGesta = T000113_A8AmGesta[0];
            n8AmGesta = T000113_n8AmGesta[0];
            AssignAttri("", false, "A8AmGesta", A8AmGesta);
            A13AmGeobs = T000113_A13AmGeobs[0];
            n13AmGeobs = T000113_n13AmGeobs[0];
            AssignAttri("", false, "A13AmGeobs", A13AmGeobs);
            A14AmgeAnio = T000113_A14AmgeAnio[0];
            n14AmgeAnio = T000113_n14AmgeAnio[0];
            AssignAttri("", false, "A14AmgeAnio", StringUtil.LTrimStr( (decimal)(A14AmgeAnio), 4, 0));
            A15AmGeusrlog = T000113_A15AmGeusrlog[0];
            n15AmGeusrlog = T000113_n15AmGeusrlog[0];
            AssignAttri("", false, "A15AmGeusrlog", A15AmGeusrlog);
            A16AmGefeclog = T000113_A16AmGefeclog[0];
            n16AmGefeclog = T000113_n16AmGefeclog[0];
            AssignAttri("", false, "A16AmGefeclog", context.localUtil.Format(A16AmGefeclog, "99/99/9999"));
            A17AmGehralog = T000113_A17AmGehralog[0];
            n17AmGehralog = T000113_n17AmGehralog[0];
            AssignAttri("", false, "A17AmGehralog", A17AmGehralog);
            A18AmgeUmedDs = T000113_A18AmgeUmedDs[0];
            A9AmgeStaGmail = T000113_A9AmgeStaGmail[0];
            n9AmgeStaGmail = T000113_n9AmgeStaGmail[0];
            A10AmGePswEMail = T000113_A10AmGePswEMail[0];
            n10AmGePswEMail = T000113_n10AmGePswEMail[0];
            A2AmgeUmedCd = T000113_A2AmgeUmedCd[0];
            n2AmgeUmedCd = T000113_n2AmgeUmedCd[0];
            ZM011( -2) ;
         }
         pr_default.close(11);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         nIsDirty_1 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A16AmGefeclog) || ( A16AmGefeclog >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo AmGefeclog fuera de rango", "OutOfRange", 1, "AMGEFECLOG");
            AnyError = 1;
            GX_FocusControl = edtAmGefeclog_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors011( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey011( )
      {
         /* Using cursor T000114 */
         pr_default.execute(12, new Object[] {A1AmGecod});
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(12);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000111 */
         pr_default.execute(9, new Object[] {A1AmGecod});
         if ( (pr_default.getStatus(9) != 101) )
         {
            ZM011( 2) ;
            RcdFound1 = 1;
            A1AmGecod = T000111_A1AmGecod[0];
            AssignAttri("", false, "A1AmGecod", A1AmGecod);
            A7AmGedes = T000111_A7AmGedes[0];
            n7AmGedes = T000111_n7AmGedes[0];
            AssignAttri("", false, "A7AmGedes", A7AmGedes);
            A11AmGeval = T000111_A11AmGeval[0];
            n11AmGeval = T000111_n11AmGeval[0];
            AssignAttri("", false, "A11AmGeval", StringUtil.LTrimStr( (decimal)(A11AmGeval), 10, 0));
            A12AmGedet = T000111_A12AmGedet[0];
            n12AmGedet = T000111_n12AmGedet[0];
            AssignAttri("", false, "A12AmGedet", A12AmGedet);
            A20AmgeAbr = T000111_A20AmgeAbr[0];
            n20AmgeAbr = T000111_n20AmgeAbr[0];
            A8AmGesta = T000111_A8AmGesta[0];
            n8AmGesta = T000111_n8AmGesta[0];
            AssignAttri("", false, "A8AmGesta", A8AmGesta);
            A13AmGeobs = T000111_A13AmGeobs[0];
            n13AmGeobs = T000111_n13AmGeobs[0];
            AssignAttri("", false, "A13AmGeobs", A13AmGeobs);
            A14AmgeAnio = T000111_A14AmgeAnio[0];
            n14AmgeAnio = T000111_n14AmgeAnio[0];
            AssignAttri("", false, "A14AmgeAnio", StringUtil.LTrimStr( (decimal)(A14AmgeAnio), 4, 0));
            A15AmGeusrlog = T000111_A15AmGeusrlog[0];
            n15AmGeusrlog = T000111_n15AmGeusrlog[0];
            AssignAttri("", false, "A15AmGeusrlog", A15AmGeusrlog);
            A16AmGefeclog = T000111_A16AmGefeclog[0];
            n16AmGefeclog = T000111_n16AmGefeclog[0];
            AssignAttri("", false, "A16AmGefeclog", context.localUtil.Format(A16AmGefeclog, "99/99/9999"));
            A17AmGehralog = T000111_A17AmGehralog[0];
            n17AmGehralog = T000111_n17AmGehralog[0];
            AssignAttri("", false, "A17AmGehralog", A17AmGehralog);
            A9AmgeStaGmail = T000111_A9AmgeStaGmail[0];
            n9AmgeStaGmail = T000111_n9AmgeStaGmail[0];
            A10AmGePswEMail = T000111_A10AmGePswEMail[0];
            n10AmGePswEMail = T000111_n10AmGePswEMail[0];
            A2AmgeUmedCd = T000111_A2AmgeUmedCd[0];
            n2AmgeUmedCd = T000111_n2AmgeUmedCd[0];
            Z1AmGecod = A1AmGecod;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode1;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(9);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0;
         /* Using cursor T000115 */
         pr_default.execute(13, new Object[] {A1AmGecod});
         if ( (pr_default.getStatus(13) != 101) )
         {
            while ( (pr_default.getStatus(13) != 101) && ( ( StringUtil.StrCmp(T000115_A1AmGecod[0], A1AmGecod) < 0 ) ) )
            {
               pr_default.readNext(13);
            }
            if ( (pr_default.getStatus(13) != 101) && ( ( StringUtil.StrCmp(T000115_A1AmGecod[0], A1AmGecod) > 0 ) ) )
            {
               A1AmGecod = T000115_A1AmGecod[0];
               AssignAttri("", false, "A1AmGecod", A1AmGecod);
               RcdFound1 = 1;
            }
         }
         pr_default.close(13);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0;
         /* Using cursor T000116 */
         pr_default.execute(14, new Object[] {A1AmGecod});
         if ( (pr_default.getStatus(14) != 101) )
         {
            while ( (pr_default.getStatus(14) != 101) && ( ( StringUtil.StrCmp(T000116_A1AmGecod[0], A1AmGecod) > 0 ) ) )
            {
               pr_default.readNext(14);
            }
            if ( (pr_default.getStatus(14) != 101) && ( ( StringUtil.StrCmp(T000116_A1AmGecod[0], A1AmGecod) < 0 ) ) )
            {
               A1AmGecod = T000116_A1AmGecod[0];
               AssignAttri("", false, "A1AmGecod", A1AmGecod);
               RcdFound1 = 1;
            }
         }
         pr_default.close(14);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtAmGecod_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert011( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( StringUtil.StrCmp(A1AmGecod, Z1AmGecod) != 0 )
               {
                  A1AmGecod = Z1AmGecod;
                  AssignAttri("", false, "A1AmGecod", A1AmGecod);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "AMGECOD");
                  AnyError = 1;
                  GX_FocusControl = edtAmGecod_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtAmGecod_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update011( ) ;
                  GX_FocusControl = edtAmGecod_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(A1AmGecod, Z1AmGecod) != 0 )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtAmGecod_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert011( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "AMGECOD");
                     AnyError = 1;
                     GX_FocusControl = edtAmGecod_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtAmGecod_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert011( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( StringUtil.StrCmp(A1AmGecod, Z1AmGecod) != 0 )
         {
            A1AmGecod = Z1AmGecod;
            AssignAttri("", false, "A1AmGecod", A1AmGecod);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "AMGECOD");
            AnyError = 1;
            GX_FocusControl = edtAmGecod_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtAmGecod_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_Check( )
      {
         nKeyPressed = 3;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         GetKey011( ) ;
         if ( RcdFound1 == 1 )
         {
            if ( IsIns( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "AMGECOD");
               AnyError = 1;
               GX_FocusControl = edtAmGecod_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(A1AmGecod, Z1AmGecod) != 0 )
            {
               A1AmGecod = Z1AmGecod;
               AssignAttri("", false, "A1AmGecod", A1AmGecod);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "AMGECOD");
               AnyError = 1;
               GX_FocusControl = edtAmGecod_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( IsDlt( ) )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               update_Check( ) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(A1AmGecod, Z1AmGecod) != 0 )
            {
               Gx_mode = "INS";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               insert_Check( ) ;
            }
            else
            {
               if ( IsUpd( ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "AMGECOD");
                  AnyError = 1;
                  GX_FocusControl = edtAmGecod_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(5);
         pr_default.close(4);
         pr_default.close(3);
         pr_default.close(2);
         pr_default.close(1);
         pr_default.close(0);
         context.RollbackDataStores("tagamge",pr_default);
         GX_FocusControl = edtAmGedes_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
      }

      protected void insert_Check( )
      {
         CONFIRM_010( ) ;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "AMGECOD");
            AnyError = 1;
            GX_FocusControl = edtAmGecod_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtAmGedes_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAmGedes_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd011( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         move_previous( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAmGedes_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         move_next( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAmGedes_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound1 != 0 )
            {
               ScanNext011( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAmGedes_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd011( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T000110 */
            pr_default.execute(8, new Object[] {A1AmGecod});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"agAmGe"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z7AmGedes, T000110_A7AmGedes[0]) != 0 ) || ( Z11AmGeval != T000110_A11AmGeval[0] ) || ( StringUtil.StrCmp(Z12AmGedet, T000110_A12AmGedet[0]) != 0 ) || ( StringUtil.StrCmp(Z20AmgeAbr, T000110_A20AmgeAbr[0]) != 0 ) || ( StringUtil.StrCmp(Z8AmGesta, T000110_A8AmGesta[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z14AmgeAnio != T000110_A14AmgeAnio[0] ) || ( StringUtil.StrCmp(Z15AmGeusrlog, T000110_A15AmGeusrlog[0]) != 0 ) || ( Z16AmGefeclog != T000110_A16AmGefeclog[0] ) || ( StringUtil.StrCmp(Z17AmGehralog, T000110_A17AmGehralog[0]) != 0 ) || ( StringUtil.StrCmp(Z9AmgeStaGmail, T000110_A9AmgeStaGmail[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z10AmGePswEMail, T000110_A10AmGePswEMail[0]) != 0 ) || ( StringUtil.StrCmp(Z2AmgeUmedCd, T000110_A2AmgeUmedCd[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z7AmGedes, T000110_A7AmGedes[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmGedes");
                  GXUtil.WriteLogRaw("Old: ",Z7AmGedes);
                  GXUtil.WriteLogRaw("Current: ",T000110_A7AmGedes[0]);
               }
               if ( Z11AmGeval != T000110_A11AmGeval[0] )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmGeval");
                  GXUtil.WriteLogRaw("Old: ",Z11AmGeval);
                  GXUtil.WriteLogRaw("Current: ",T000110_A11AmGeval[0]);
               }
               if ( StringUtil.StrCmp(Z12AmGedet, T000110_A12AmGedet[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmGedet");
                  GXUtil.WriteLogRaw("Old: ",Z12AmGedet);
                  GXUtil.WriteLogRaw("Current: ",T000110_A12AmGedet[0]);
               }
               if ( StringUtil.StrCmp(Z20AmgeAbr, T000110_A20AmgeAbr[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeAbr");
                  GXUtil.WriteLogRaw("Old: ",Z20AmgeAbr);
                  GXUtil.WriteLogRaw("Current: ",T000110_A20AmgeAbr[0]);
               }
               if ( StringUtil.StrCmp(Z8AmGesta, T000110_A8AmGesta[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmGesta");
                  GXUtil.WriteLogRaw("Old: ",Z8AmGesta);
                  GXUtil.WriteLogRaw("Current: ",T000110_A8AmGesta[0]);
               }
               if ( Z14AmgeAnio != T000110_A14AmgeAnio[0] )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeAnio");
                  GXUtil.WriteLogRaw("Old: ",Z14AmgeAnio);
                  GXUtil.WriteLogRaw("Current: ",T000110_A14AmgeAnio[0]);
               }
               if ( StringUtil.StrCmp(Z15AmGeusrlog, T000110_A15AmGeusrlog[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmGeusrlog");
                  GXUtil.WriteLogRaw("Old: ",Z15AmGeusrlog);
                  GXUtil.WriteLogRaw("Current: ",T000110_A15AmGeusrlog[0]);
               }
               if ( Z16AmGefeclog != T000110_A16AmGefeclog[0] )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmGefeclog");
                  GXUtil.WriteLogRaw("Old: ",Z16AmGefeclog);
                  GXUtil.WriteLogRaw("Current: ",T000110_A16AmGefeclog[0]);
               }
               if ( StringUtil.StrCmp(Z17AmGehralog, T000110_A17AmGehralog[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmGehralog");
                  GXUtil.WriteLogRaw("Old: ",Z17AmGehralog);
                  GXUtil.WriteLogRaw("Current: ",T000110_A17AmGehralog[0]);
               }
               if ( StringUtil.StrCmp(Z9AmgeStaGmail, T000110_A9AmgeStaGmail[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeStaGmail");
                  GXUtil.WriteLogRaw("Old: ",Z9AmgeStaGmail);
                  GXUtil.WriteLogRaw("Current: ",T000110_A9AmgeStaGmail[0]);
               }
               if ( StringUtil.StrCmp(Z10AmGePswEMail, T000110_A10AmGePswEMail[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmGePswEMail");
                  GXUtil.WriteLogRaw("Old: ",Z10AmGePswEMail);
                  GXUtil.WriteLogRaw("Current: ",T000110_A10AmGePswEMail[0]);
               }
               if ( StringUtil.StrCmp(Z2AmgeUmedCd, T000110_A2AmgeUmedCd[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeUmedCd");
                  GXUtil.WriteLogRaw("Old: ",Z2AmgeUmedCd);
                  GXUtil.WriteLogRaw("Current: ",T000110_A2AmgeUmedCd[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"agAmGe"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000117 */
                     pr_default.execute(15, new Object[] {A1AmGecod, n7AmGedes, A7AmGedes, n11AmGeval, A11AmGeval, n12AmGedet, A12AmGedet, n20AmgeAbr, A20AmgeAbr, n8AmGesta, A8AmGesta, n13AmGeobs, A13AmGeobs, n14AmgeAnio, A14AmgeAnio, n15AmGeusrlog, A15AmGeusrlog, n16AmGefeclog, A16AmGefeclog, n17AmGehralog, A17AmGehralog, n9AmgeStaGmail, A9AmgeStaGmail, n10AmGePswEMail, A10AmGePswEMail, n2AmgeUmedCd, A2AmgeUmedCd});
                     pr_default.close(15);
                     dsDefault.SmartCacheProvider.SetUpdated("agAmGe") ;
                     if ( (pr_default.getStatus(15) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel011( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              endTrnMsgTxt = context.GetMessage( "GXM_sucadded", "");
                              endTrnMsgCod = "SuccessfullyAdded";
                              ResetCaption010( ) ;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000118 */
                     pr_default.execute(16, new Object[] {n7AmGedes, A7AmGedes, n11AmGeval, A11AmGeval, n12AmGedet, A12AmGedet, n20AmgeAbr, A20AmgeAbr, n8AmGesta, A8AmGesta, n13AmGeobs, A13AmGeobs, n14AmgeAnio, A14AmgeAnio, n15AmGeusrlog, A15AmGeusrlog, n16AmGefeclog, A16AmGefeclog, n17AmGehralog, A17AmGehralog, n9AmgeStaGmail, A9AmgeStaGmail, n10AmGePswEMail, A10AmGePswEMail, n2AmgeUmedCd, A2AmgeUmedCd, A1AmGecod});
                     pr_default.close(16);
                     dsDefault.SmartCacheProvider.SetUpdated("agAmGe") ;
                     if ( (pr_default.getStatus(16) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"agAmGe"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel011( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              endTrnMsgTxt = context.GetMessage( "GXM_sucupdated", "");
                              endTrnMsgCod = "SuccessfullyUpdated";
                              ResetCaption010( ) ;
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart016( ) ;
                  while ( RcdFound6 != 0 )
                  {
                     getByPrimaryKey016( ) ;
                     Delete016( ) ;
                     ScanNext016( ) ;
                  }
                  ScanEnd016( ) ;
                  ScanStart014( ) ;
                  while ( RcdFound4 != 0 )
                  {
                     getByPrimaryKey014( ) ;
                     Delete014( ) ;
                     ScanNext014( ) ;
                  }
                  ScanEnd014( ) ;
                  ScanStart013( ) ;
                  while ( RcdFound3 != 0 )
                  {
                     getByPrimaryKey013( ) ;
                     Delete013( ) ;
                     ScanNext013( ) ;
                  }
                  ScanEnd013( ) ;
                  ScanStart012( ) ;
                  while ( RcdFound2 != 0 )
                  {
                     getByPrimaryKey012( ) ;
                     Delete012( ) ;
                     ScanNext012( ) ;
                  }
                  ScanEnd012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000119 */
                     pr_default.execute(17, new Object[] {A1AmGecod});
                     pr_default.close(17);
                     dsDefault.SmartCacheProvider.SetUpdated("agAmGe") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound1 == 0 )
                           {
                              InitAll011( ) ;
                              Gx_mode = "INS";
                              AssignAttri("", false, "Gx_mode", Gx_mode);
                           }
                           else
                           {
                              getByPrimaryKey( ) ;
                              Gx_mode = "UPD";
                              AssignAttri("", false, "Gx_mode", Gx_mode);
                           }
                           endTrnMsgTxt = context.GetMessage( "GXM_sucdeleted", "");
                           endTrnMsgCod = "SuccessfullyDeleted";
                           ResetCaption010( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
         }
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel011( ) ;
         Gx_mode = sMode1;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void ProcessNestedLevel012( )
      {
         nGXsfl_104_idx = 0;
         while ( nGXsfl_104_idx < nRC_GXsfl_104 )
         {
            ReadRow012( ) ;
            if ( ( nRcdExists_2 != 0 ) || ( nIsMod_2 != 0 ) )
            {
               standaloneNotModal012( ) ;
               GetKey012( ) ;
               if ( ( nRcdExists_2 == 0 ) && ( nRcdDeleted_2 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  Insert012( ) ;
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( ( nRcdDeleted_2 != 0 ) && ( nRcdExists_2 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        Delete012( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_2 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           Update012( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_2 == 0 )
                     {
                        GXCCtl = "AMGEWSSEC_" + sGXsfl_104_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtAmgewsSec_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtAmgewsSec_Internalname, StringUtil.RTrim( A3AmgewsSec)) ;
            ChangePostValue( edtAmgeWsPort_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A21AmgeWsPort), 4, 0, ",", ""))) ;
            ChangePostValue( edtAmgeWsHost_Internalname, StringUtil.RTrim( A22AmgeWsHost)) ;
            ChangePostValue( edtAmgeWsUri_Internalname, A23AmgeWsUri) ;
            ChangePostValue( edtAmgeWsLoc_Internalname, StringUtil.RTrim( A24AmgeWsLoc)) ;
            ChangePostValue( edtAmgeWsTip_Internalname, StringUtil.RTrim( A25AmgeWsTip)) ;
            ChangePostValue( edtAmgeWsEst_Internalname, StringUtil.RTrim( A26AmgeWsEst)) ;
            ChangePostValue( "ZT_"+"Z3AmgewsSec_"+sGXsfl_104_idx, StringUtil.RTrim( Z3AmgewsSec)) ;
            ChangePostValue( "ZT_"+"Z21AmgeWsPort_"+sGXsfl_104_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z21AmgeWsPort), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z22AmgeWsHost_"+sGXsfl_104_idx, StringUtil.RTrim( Z22AmgeWsHost)) ;
            ChangePostValue( "ZT_"+"Z23AmgeWsUri_"+sGXsfl_104_idx, Z23AmgeWsUri) ;
            ChangePostValue( "ZT_"+"Z24AmgeWsLoc_"+sGXsfl_104_idx, StringUtil.RTrim( Z24AmgeWsLoc)) ;
            ChangePostValue( "ZT_"+"Z25AmgeWsTip_"+sGXsfl_104_idx, StringUtil.RTrim( Z25AmgeWsTip)) ;
            ChangePostValue( "ZT_"+"Z26AmgeWsEst_"+sGXsfl_104_idx, StringUtil.RTrim( Z26AmgeWsEst)) ;
            ChangePostValue( "nRcdDeleted_2_"+sGXsfl_104_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_2_"+sGXsfl_104_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_2_"+sGXsfl_104_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ",", ""))) ;
            if ( nIsMod_2 != 0 )
            {
               ChangePostValue( "AMGEWSSEC_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgewsSec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEWSPORT_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsPort_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEWSHOST_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsHost_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEWSURI_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsUri_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEWSLOC_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsLoc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEWSTIP_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsTip_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEWSEST_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsEst_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll012( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_2 = 0;
         nIsMod_2 = 0;
         nRcdDeleted_2 = 0;
      }

      protected void ProcessNestedLevel013( )
      {
         nGXsfl_97_idx = 0;
         while ( nGXsfl_97_idx < nRC_GXsfl_97 )
         {
            ReadRow013( ) ;
            if ( ( nRcdExists_3 != 0 ) || ( nIsMod_3 != 0 ) )
            {
               standaloneNotModal013( ) ;
               GetKey013( ) ;
               if ( ( nRcdExists_3 == 0 ) && ( nRcdDeleted_3 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  Insert013( ) ;
               }
               else
               {
                  if ( RcdFound3 != 0 )
                  {
                     if ( ( nRcdDeleted_3 != 0 ) && ( nRcdExists_3 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        Delete013( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_3 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           Update013( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_3 == 0 )
                     {
                        GXCCtl = "AMGESEC2_" + sGXsfl_97_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtAmgeSec2_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtAmgeSec2_Internalname, StringUtil.RTrim( A4AmgeSec2)) ;
            ChangePostValue( edtAmgeNoPesIni_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27AmgeNoPesIni), 4, 0, ",", ""))) ;
            ChangePostValue( edtAmgeNoPesTer_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A28AmgeNoPesTer), 4, 0, ",", ""))) ;
            ChangePostValue( edtAmgeValPago_Internalname, StringUtil.LTrim( StringUtil.NToC( A29AmgeValPago, 9, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z4AmgeSec2_"+sGXsfl_97_idx, StringUtil.RTrim( Z4AmgeSec2)) ;
            ChangePostValue( "ZT_"+"Z27AmgeNoPesIni_"+sGXsfl_97_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27AmgeNoPesIni), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z28AmgeNoPesTer_"+sGXsfl_97_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z28AmgeNoPesTer), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z29AmgeValPago_"+sGXsfl_97_idx, StringUtil.LTrim( StringUtil.NToC( Z29AmgeValPago, 8, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_3_"+sGXsfl_97_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_3), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_3_"+sGXsfl_97_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_3), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_3_"+sGXsfl_97_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_3), 4, 0, ",", ""))) ;
            if ( nIsMod_3 != 0 )
            {
               ChangePostValue( "AMGESEC2_"+sGXsfl_97_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeSec2_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGENOPESINI_"+sGXsfl_97_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeNoPesIni_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGENOPESTER_"+sGXsfl_97_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeNoPesTer_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEVALPAGO_"+sGXsfl_97_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeValPago_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll013( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_3 = 0;
         nIsMod_3 = 0;
         nRcdDeleted_3 = 0;
      }

      protected void ProcessNestedLevel014( )
      {
         nGXsfl_91_idx = 0;
         while ( nGXsfl_91_idx < nRC_GXsfl_91 )
         {
            ReadRow014( ) ;
            if ( ( nRcdExists_4 != 0 ) || ( nIsMod_4 != 0 ) )
            {
               standaloneNotModal014( ) ;
               GetKey014( ) ;
               if ( ( nRcdExists_4 == 0 ) && ( nRcdDeleted_4 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  Insert014( ) ;
               }
               else
               {
                  if ( RcdFound4 != 0 )
                  {
                     if ( ( nRcdDeleted_4 != 0 ) && ( nRcdExists_4 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        Delete014( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_4 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           Update014( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_4 == 0 )
                     {
                        GXCCtl = "AMGESEC_" + sGXsfl_91_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtAmGeSec_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtavnRcdDeleted_4_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_4), 4, 0, ",", ""))) ;
            ChangePostValue( edtAmGeSec_Internalname, StringUtil.RTrim( A5AmGeSec)) ;
            ChangePostValue( edtAmGeMail_Internalname, StringUtil.RTrim( A30AmGeMail)) ;
            ChangePostValue( "ZT_"+"Z5AmGeSec_"+sGXsfl_91_idx, StringUtil.RTrim( Z5AmGeSec)) ;
            ChangePostValue( "ZT_"+"Z30AmGeMail_"+sGXsfl_91_idx, StringUtil.RTrim( Z30AmGeMail)) ;
            ChangePostValue( "nRcdDeleted_4_"+sGXsfl_91_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_4), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_4_"+sGXsfl_91_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_4), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_4_"+sGXsfl_91_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_4), 4, 0, ",", ""))) ;
            if ( nIsMod_4 != 0 )
            {
               ChangePostValue( "vNRCDDELETED_4_"+sGXsfl_91_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavnRcdDeleted_4_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGESEC_"+sGXsfl_91_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmGeSec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEMAIL_"+sGXsfl_91_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmGeMail_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll014( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_4 = 0;
         nIsMod_4 = 0;
         nRcdDeleted_4 = 0;
      }

      protected void ProcessNestedLevel016( )
      {
         nGXsfl_114_idx = 0;
         while ( nGXsfl_114_idx < nRC_GXsfl_114 )
         {
            ReadRow016( ) ;
            if ( ( nRcdExists_6 != 0 ) || ( nIsMod_6 != 0 ) )
            {
               standaloneNotModal016( ) ;
               GetKey016( ) ;
               if ( ( nRcdExists_6 == 0 ) && ( nRcdDeleted_6 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  Insert016( ) ;
               }
               else
               {
                  if ( RcdFound6 != 0 )
                  {
                     if ( ( nRcdDeleted_6 != 0 ) && ( nRcdExists_6 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        Delete016( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_6 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           Update016( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_6 == 0 )
                     {
                        GXCCtl = "AMGEMAILSEC_" + sGXsfl_114_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtAmGeMailSec_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtAmGeMailSec_Internalname, StringUtil.RTrim( A43AmGeMailSec)) ;
            ChangePostValue( chkAmgeMailSecure_Internalname, StringUtil.BoolToStr( A50AmgeMailSecure)) ;
            ChangePostValue( "ZT_"+"Z43AmGeMailSec_"+sGXsfl_114_idx, StringUtil.RTrim( Z43AmGeMailSec)) ;
            ChangePostValue( "ZT_"+"Z44AmGeMailPort_"+sGXsfl_114_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z44AmGeMailPort), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z45AmGeMailHost_"+sGXsfl_114_idx, Z45AmGeMailHost) ;
            ChangePostValue( "ZT_"+"Z46AmGeMailSender_"+sGXsfl_114_idx, Z46AmGeMailSender) ;
            ChangePostValue( "ZT_"+"Z47AmgeMailUser_"+sGXsfl_114_idx, Z47AmgeMailUser) ;
            ChangePostValue( "ZT_"+"Z48AmgeMailPassword_"+sGXsfl_114_idx, Z48AmgeMailPassword) ;
            ChangePostValue( "ZT_"+"Z49AmgeMailAuthentication_"+sGXsfl_114_idx, StringUtil.BoolToStr( Z49AmgeMailAuthentication)) ;
            ChangePostValue( "ZT_"+"Z50AmgeMailSecure_"+sGXsfl_114_idx, StringUtil.BoolToStr( Z50AmgeMailSecure)) ;
            ChangePostValue( "ZT_"+"Z51AmgeMailEstado_"+sGXsfl_114_idx, StringUtil.RTrim( Z51AmgeMailEstado)) ;
            ChangePostValue( "nRcdDeleted_6_"+sGXsfl_114_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_6), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_6_"+sGXsfl_114_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_6), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_6_"+sGXsfl_114_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_6), 4, 0, ",", ""))) ;
            if ( nIsMod_6 != 0 )
            {
               ChangePostValue( "AMGEMAILSEC_"+sGXsfl_114_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmGeMailSec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "AMGEMAILSECURE_"+sGXsfl_114_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkAmgeMailSecure.Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll016( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_6 = 0;
         nIsMod_6 = 0;
         nRcdDeleted_6 = 0;
      }

      protected void ProcessLevel011( )
      {
         /* Save parent mode. */
         sMode1 = Gx_mode;
         ProcessNestedLevel012( ) ;
         ProcessNestedLevel013( ) ;
         ProcessNestedLevel014( ) ;
         ProcessNestedLevel016( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode1;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel011( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(5);
            pr_default.close(4);
            pr_default.close(3);
            pr_default.close(2);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("tagamge",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues010( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(5);
            pr_default.close(4);
            pr_default.close(3);
            pr_default.close(2);
            pr_default.close(1);
            pr_default.close(0);
            context.RollbackDataStores("tagamge",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart011( )
      {
         /* Using cursor T000120 */
         pr_default.execute(18);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound1 = 1;
            A1AmGecod = T000120_A1AmGecod[0];
            AssignAttri("", false, "A1AmGecod", A1AmGecod);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(18);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound1 = 1;
            A1AmGecod = T000120_A1AmGecod[0];
            AssignAttri("", false, "A1AmGecod", A1AmGecod);
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(18);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
         edtAmGecod_Enabled = 0;
         AssignProp("", false, edtAmGecod_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGecod_Enabled), 5, 0), true);
         edtAmGedes_Enabled = 0;
         AssignProp("", false, edtAmGedes_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGedes_Enabled), 5, 0), true);
         edtAmGeval_Enabled = 0;
         AssignProp("", false, edtAmGeval_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeval_Enabled), 5, 0), true);
         edtAmGedet_Enabled = 0;
         AssignProp("", false, edtAmGedet_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGedet_Enabled), 5, 0), true);
         edtAmGesta_Enabled = 0;
         AssignProp("", false, edtAmGesta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGesta_Enabled), 5, 0), true);
         edtAmGeobs_Enabled = 0;
         AssignProp("", false, edtAmGeobs_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeobs_Enabled), 5, 0), true);
         edtAmgeAnio_Enabled = 0;
         AssignProp("", false, edtAmgeAnio_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeAnio_Enabled), 5, 0), true);
         edtAmGeusrlog_Enabled = 0;
         AssignProp("", false, edtAmGeusrlog_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeusrlog_Enabled), 5, 0), true);
         edtAmGefeclog_Enabled = 0;
         AssignProp("", false, edtAmGefeclog_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGefeclog_Enabled), 5, 0), true);
         edtAmGehralog_Enabled = 0;
         AssignProp("", false, edtAmGehralog_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGehralog_Enabled), 5, 0), true);
      }

      protected void ZM012( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z21AmgeWsPort = T00019_A21AmgeWsPort[0];
               Z22AmgeWsHost = T00019_A22AmgeWsHost[0];
               Z23AmgeWsUri = T00019_A23AmgeWsUri[0];
               Z24AmgeWsLoc = T00019_A24AmgeWsLoc[0];
               Z25AmgeWsTip = T00019_A25AmgeWsTip[0];
               Z26AmgeWsEst = T00019_A26AmgeWsEst[0];
            }
            else
            {
               Z21AmgeWsPort = A21AmgeWsPort;
               Z22AmgeWsHost = A22AmgeWsHost;
               Z23AmgeWsUri = A23AmgeWsUri;
               Z24AmgeWsLoc = A24AmgeWsLoc;
               Z25AmgeWsTip = A25AmgeWsTip;
               Z26AmgeWsEst = A26AmgeWsEst;
            }
         }
         if ( GX_JID == -4 )
         {
            Z1AmGecod = A1AmGecod;
            Z3AmgewsSec = A3AmgewsSec;
            Z21AmgeWsPort = A21AmgeWsPort;
            Z22AmgeWsHost = A22AmgeWsHost;
            Z23AmgeWsUri = A23AmgeWsUri;
            Z24AmgeWsLoc = A24AmgeWsLoc;
            Z25AmgeWsTip = A25AmgeWsTip;
            Z26AmgeWsEst = A26AmgeWsEst;
         }
      }

      protected void standaloneNotModal012( )
      {
      }

      protected void standaloneModal012( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtAmgewsSec_Enabled = 0;
            AssignProp("", false, edtAmgewsSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgewsSec_Enabled), 5, 0), !bGXsfl_104_Refreshing);
         }
         else
         {
            edtAmgewsSec_Enabled = 1;
            AssignProp("", false, edtAmgewsSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgewsSec_Enabled), 5, 0), !bGXsfl_104_Refreshing);
         }
      }

      protected void Load012( )
      {
         /* Using cursor T000121 */
         pr_default.execute(19, new Object[] {A1AmGecod, A3AmgewsSec});
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound2 = 1;
            A21AmgeWsPort = T000121_A21AmgeWsPort[0];
            A22AmgeWsHost = T000121_A22AmgeWsHost[0];
            A23AmgeWsUri = T000121_A23AmgeWsUri[0];
            A24AmgeWsLoc = T000121_A24AmgeWsLoc[0];
            A25AmgeWsTip = T000121_A25AmgeWsTip[0];
            A26AmgeWsEst = T000121_A26AmgeWsEst[0];
            ZM012( -4) ;
         }
         pr_default.close(19);
         OnLoadActions012( ) ;
      }

      protected void OnLoadActions012( )
      {
      }

      protected void CheckExtendedTable012( )
      {
         nIsDirty_2 = 0;
         Gx_BScreen = 1;
         standaloneModal012( ) ;
      }

      protected void CloseExtendedTableCursors012( )
      {
      }

      protected void enableDisable012( )
      {
      }

      protected void GetKey012( )
      {
         /* Using cursor T000122 */
         pr_default.execute(20, new Object[] {A1AmGecod, A3AmgewsSec});
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(20);
      }

      protected void getByPrimaryKey012( )
      {
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {A1AmGecod, A3AmgewsSec});
         if ( (pr_default.getStatus(7) != 101) )
         {
            ZM012( 4) ;
            RcdFound2 = 1;
            InitializeNonKey012( ) ;
            A3AmgewsSec = T00019_A3AmgewsSec[0];
            A21AmgeWsPort = T00019_A21AmgeWsPort[0];
            A22AmgeWsHost = T00019_A22AmgeWsHost[0];
            A23AmgeWsUri = T00019_A23AmgeWsUri[0];
            A24AmgeWsLoc = T00019_A24AmgeWsLoc[0];
            A25AmgeWsTip = T00019_A25AmgeWsTip[0];
            A26AmgeWsEst = T00019_A26AmgeWsEst[0];
            Z1AmGecod = A1AmGecod;
            Z3AmgewsSec = A3AmgewsSec;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal012( ) ;
            Load012( ) ;
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey012( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal012( ) ;
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes012( ) ;
         }
         pr_default.close(7);
      }

      protected void CheckOptimisticConcurrency012( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00018 */
            pr_default.execute(6, new Object[] {A1AmGecod, A3AmgewsSec});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AgAmGe3"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(6) == 101) || ( Z21AmgeWsPort != T00018_A21AmgeWsPort[0] ) || ( StringUtil.StrCmp(Z22AmgeWsHost, T00018_A22AmgeWsHost[0]) != 0 ) || ( StringUtil.StrCmp(Z23AmgeWsUri, T00018_A23AmgeWsUri[0]) != 0 ) || ( StringUtil.StrCmp(Z24AmgeWsLoc, T00018_A24AmgeWsLoc[0]) != 0 ) || ( StringUtil.StrCmp(Z25AmgeWsTip, T00018_A25AmgeWsTip[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z26AmgeWsEst, T00018_A26AmgeWsEst[0]) != 0 ) )
            {
               if ( Z21AmgeWsPort != T00018_A21AmgeWsPort[0] )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeWsPort");
                  GXUtil.WriteLogRaw("Old: ",Z21AmgeWsPort);
                  GXUtil.WriteLogRaw("Current: ",T00018_A21AmgeWsPort[0]);
               }
               if ( StringUtil.StrCmp(Z22AmgeWsHost, T00018_A22AmgeWsHost[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeWsHost");
                  GXUtil.WriteLogRaw("Old: ",Z22AmgeWsHost);
                  GXUtil.WriteLogRaw("Current: ",T00018_A22AmgeWsHost[0]);
               }
               if ( StringUtil.StrCmp(Z23AmgeWsUri, T00018_A23AmgeWsUri[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeWsUri");
                  GXUtil.WriteLogRaw("Old: ",Z23AmgeWsUri);
                  GXUtil.WriteLogRaw("Current: ",T00018_A23AmgeWsUri[0]);
               }
               if ( StringUtil.StrCmp(Z24AmgeWsLoc, T00018_A24AmgeWsLoc[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeWsLoc");
                  GXUtil.WriteLogRaw("Old: ",Z24AmgeWsLoc);
                  GXUtil.WriteLogRaw("Current: ",T00018_A24AmgeWsLoc[0]);
               }
               if ( StringUtil.StrCmp(Z25AmgeWsTip, T00018_A25AmgeWsTip[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeWsTip");
                  GXUtil.WriteLogRaw("Old: ",Z25AmgeWsTip);
                  GXUtil.WriteLogRaw("Current: ",T00018_A25AmgeWsTip[0]);
               }
               if ( StringUtil.StrCmp(Z26AmgeWsEst, T00018_A26AmgeWsEst[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeWsEst");
                  GXUtil.WriteLogRaw("Old: ",Z26AmgeWsEst);
                  GXUtil.WriteLogRaw("Current: ",T00018_A26AmgeWsEst[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"AgAmGe3"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert012( )
      {
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable012( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM012( 0) ;
            CheckOptimisticConcurrency012( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm012( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000123 */
                     pr_default.execute(21, new Object[] {A1AmGecod, A3AmgewsSec, A21AmgeWsPort, A22AmgeWsHost, A23AmgeWsUri, A24AmgeWsLoc, A25AmgeWsTip, A26AmgeWsEst});
                     pr_default.close(21);
                     dsDefault.SmartCacheProvider.SetUpdated("AgAmGe3") ;
                     if ( (pr_default.getStatus(21) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load012( ) ;
            }
            EndLevel012( ) ;
         }
         CloseExtendedTableCursors012( ) ;
      }

      protected void Update012( )
      {
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable012( ) ;
         }
         if ( ( nIsMod_2 != 0 ) || ( nIsDirty_2 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency012( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm012( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate012( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Using cursor T000124 */
                        pr_default.execute(22, new Object[] {A21AmgeWsPort, A22AmgeWsHost, A23AmgeWsUri, A24AmgeWsLoc, A25AmgeWsTip, A26AmgeWsEst, A1AmGecod, A3AmgewsSec});
                        pr_default.close(22);
                        dsDefault.SmartCacheProvider.SetUpdated("AgAmGe3") ;
                        if ( (pr_default.getStatus(22) == 103) )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AgAmGe3"}), "RecordIsLocked", 1, "");
                           AnyError = 1;
                        }
                        DeferredUpdate012( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey012( ) ;
                           }
                        }
                        else
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                           AnyError = 1;
                        }
                     }
                  }
               }
               EndLevel012( ) ;
            }
         }
         CloseExtendedTableCursors012( ) ;
      }

      protected void DeferredUpdate012( )
      {
      }

      protected void Delete012( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency012( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls012( ) ;
            AfterConfirm012( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete012( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000125 */
                  pr_default.execute(23, new Object[] {A1AmGecod, A3AmgewsSec});
                  pr_default.close(23);
                  dsDefault.SmartCacheProvider.SetUpdated("AgAmGe3") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel012( ) ;
         Gx_mode = sMode2;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls012( )
      {
         standaloneModal012( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel012( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(6);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart012( )
      {
         /* Scan By routine */
         /* Using cursor T000126 */
         pr_default.execute(24, new Object[] {A1AmGecod});
         RcdFound2 = 0;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound2 = 1;
            A3AmgewsSec = T000126_A3AmgewsSec[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext012( )
      {
         /* Scan next routine */
         pr_default.readNext(24);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound2 = 1;
            A3AmgewsSec = T000126_A3AmgewsSec[0];
         }
      }

      protected void ScanEnd012( )
      {
         pr_default.close(24);
      }

      protected void AfterConfirm012( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert012( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate012( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete012( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete012( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate012( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes012( )
      {
         edtAmgewsSec_Enabled = 0;
         AssignProp("", false, edtAmgewsSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgewsSec_Enabled), 5, 0), !bGXsfl_104_Refreshing);
         edtAmgeWsPort_Enabled = 0;
         AssignProp("", false, edtAmgeWsPort_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeWsPort_Enabled), 5, 0), !bGXsfl_104_Refreshing);
         edtAmgeWsHost_Enabled = 0;
         AssignProp("", false, edtAmgeWsHost_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeWsHost_Enabled), 5, 0), !bGXsfl_104_Refreshing);
         edtAmgeWsUri_Enabled = 0;
         AssignProp("", false, edtAmgeWsUri_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeWsUri_Enabled), 5, 0), !bGXsfl_104_Refreshing);
         edtAmgeWsLoc_Enabled = 0;
         AssignProp("", false, edtAmgeWsLoc_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeWsLoc_Enabled), 5, 0), !bGXsfl_104_Refreshing);
         edtAmgeWsTip_Enabled = 0;
         AssignProp("", false, edtAmgeWsTip_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeWsTip_Enabled), 5, 0), !bGXsfl_104_Refreshing);
         edtAmgeWsEst_Enabled = 0;
         AssignProp("", false, edtAmgeWsEst_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeWsEst_Enabled), 5, 0), !bGXsfl_104_Refreshing);
      }

      protected void send_integrity_lvl_hashes012( )
      {
      }

      protected void ZM013( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z27AmgeNoPesIni = T00017_A27AmgeNoPesIni[0];
               Z28AmgeNoPesTer = T00017_A28AmgeNoPesTer[0];
               Z29AmgeValPago = T00017_A29AmgeValPago[0];
            }
            else
            {
               Z27AmgeNoPesIni = A27AmgeNoPesIni;
               Z28AmgeNoPesTer = A28AmgeNoPesTer;
               Z29AmgeValPago = A29AmgeValPago;
            }
         }
         if ( GX_JID == -5 )
         {
            Z1AmGecod = A1AmGecod;
            Z4AmgeSec2 = A4AmgeSec2;
            Z27AmgeNoPesIni = A27AmgeNoPesIni;
            Z28AmgeNoPesTer = A28AmgeNoPesTer;
            Z29AmgeValPago = A29AmgeValPago;
         }
      }

      protected void standaloneNotModal013( )
      {
      }

      protected void standaloneModal013( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtAmgeSec2_Enabled = 0;
            AssignProp("", false, edtAmgeSec2_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeSec2_Enabled), 5, 0), !bGXsfl_97_Refreshing);
         }
         else
         {
            edtAmgeSec2_Enabled = 1;
            AssignProp("", false, edtAmgeSec2_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeSec2_Enabled), 5, 0), !bGXsfl_97_Refreshing);
         }
      }

      protected void Load013( )
      {
         /* Using cursor T000127 */
         pr_default.execute(25, new Object[] {A1AmGecod, A4AmgeSec2});
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound3 = 1;
            A27AmgeNoPesIni = T000127_A27AmgeNoPesIni[0];
            n27AmgeNoPesIni = T000127_n27AmgeNoPesIni[0];
            A28AmgeNoPesTer = T000127_A28AmgeNoPesTer[0];
            n28AmgeNoPesTer = T000127_n28AmgeNoPesTer[0];
            A29AmgeValPago = T000127_A29AmgeValPago[0];
            n29AmgeValPago = T000127_n29AmgeValPago[0];
            ZM013( -5) ;
         }
         pr_default.close(25);
         OnLoadActions013( ) ;
      }

      protected void OnLoadActions013( )
      {
      }

      protected void CheckExtendedTable013( )
      {
         nIsDirty_3 = 0;
         Gx_BScreen = 1;
         standaloneModal013( ) ;
      }

      protected void CloseExtendedTableCursors013( )
      {
      }

      protected void enableDisable013( )
      {
      }

      protected void GetKey013( )
      {
         /* Using cursor T000128 */
         pr_default.execute(26, new Object[] {A1AmGecod, A4AmgeSec2});
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound3 = 1;
         }
         else
         {
            RcdFound3 = 0;
         }
         pr_default.close(26);
      }

      protected void getByPrimaryKey013( )
      {
         /* Using cursor T00017 */
         pr_default.execute(5, new Object[] {A1AmGecod, A4AmgeSec2});
         if ( (pr_default.getStatus(5) != 101) )
         {
            ZM013( 5) ;
            RcdFound3 = 1;
            InitializeNonKey013( ) ;
            A4AmgeSec2 = T00017_A4AmgeSec2[0];
            A27AmgeNoPesIni = T00017_A27AmgeNoPesIni[0];
            n27AmgeNoPesIni = T00017_n27AmgeNoPesIni[0];
            A28AmgeNoPesTer = T00017_A28AmgeNoPesTer[0];
            n28AmgeNoPesTer = T00017_n28AmgeNoPesTer[0];
            A29AmgeValPago = T00017_A29AmgeValPago[0];
            n29AmgeValPago = T00017_n29AmgeValPago[0];
            Z1AmGecod = A1AmGecod;
            Z4AmgeSec2 = A4AmgeSec2;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal013( ) ;
            Load013( ) ;
            Gx_mode = sMode3;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound3 = 0;
            InitializeNonKey013( ) ;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal013( ) ;
            Gx_mode = sMode3;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes013( ) ;
         }
         pr_default.close(5);
      }

      protected void CheckOptimisticConcurrency013( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00016 */
            pr_default.execute(4, new Object[] {A1AmGecod, A4AmgeSec2});
            if ( (pr_default.getStatus(4) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AgAmGe2"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(4) == 101) || ( Z27AmgeNoPesIni != T00016_A27AmgeNoPesIni[0] ) || ( Z28AmgeNoPesTer != T00016_A28AmgeNoPesTer[0] ) || ( Z29AmgeValPago != T00016_A29AmgeValPago[0] ) )
            {
               if ( Z27AmgeNoPesIni != T00016_A27AmgeNoPesIni[0] )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeNoPesIni");
                  GXUtil.WriteLogRaw("Old: ",Z27AmgeNoPesIni);
                  GXUtil.WriteLogRaw("Current: ",T00016_A27AmgeNoPesIni[0]);
               }
               if ( Z28AmgeNoPesTer != T00016_A28AmgeNoPesTer[0] )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeNoPesTer");
                  GXUtil.WriteLogRaw("Old: ",Z28AmgeNoPesTer);
                  GXUtil.WriteLogRaw("Current: ",T00016_A28AmgeNoPesTer[0]);
               }
               if ( Z29AmgeValPago != T00016_A29AmgeValPago[0] )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeValPago");
                  GXUtil.WriteLogRaw("Old: ",Z29AmgeValPago);
                  GXUtil.WriteLogRaw("Current: ",T00016_A29AmgeValPago[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"AgAmGe2"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert013( )
      {
         BeforeValidate013( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable013( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM013( 0) ;
            CheckOptimisticConcurrency013( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm013( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert013( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000129 */
                     pr_default.execute(27, new Object[] {A1AmGecod, A4AmgeSec2, n27AmgeNoPesIni, A27AmgeNoPesIni, n28AmgeNoPesTer, A28AmgeNoPesTer, n29AmgeValPago, A29AmgeValPago});
                     pr_default.close(27);
                     dsDefault.SmartCacheProvider.SetUpdated("AgAmGe2") ;
                     if ( (pr_default.getStatus(27) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load013( ) ;
            }
            EndLevel013( ) ;
         }
         CloseExtendedTableCursors013( ) ;
      }

      protected void Update013( )
      {
         BeforeValidate013( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable013( ) ;
         }
         if ( ( nIsMod_3 != 0 ) || ( nIsDirty_3 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency013( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm013( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate013( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Using cursor T000130 */
                        pr_default.execute(28, new Object[] {n27AmgeNoPesIni, A27AmgeNoPesIni, n28AmgeNoPesTer, A28AmgeNoPesTer, n29AmgeValPago, A29AmgeValPago, A1AmGecod, A4AmgeSec2});
                        pr_default.close(28);
                        dsDefault.SmartCacheProvider.SetUpdated("AgAmGe2") ;
                        if ( (pr_default.getStatus(28) == 103) )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AgAmGe2"}), "RecordIsLocked", 1, "");
                           AnyError = 1;
                        }
                        DeferredUpdate013( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey013( ) ;
                           }
                        }
                        else
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                           AnyError = 1;
                        }
                     }
                  }
               }
               EndLevel013( ) ;
            }
         }
         CloseExtendedTableCursors013( ) ;
      }

      protected void DeferredUpdate013( )
      {
      }

      protected void Delete013( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate013( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency013( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls013( ) ;
            AfterConfirm013( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete013( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000131 */
                  pr_default.execute(29, new Object[] {A1AmGecod, A4AmgeSec2});
                  pr_default.close(29);
                  dsDefault.SmartCacheProvider.SetUpdated("AgAmGe2") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode3 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel013( ) ;
         Gx_mode = sMode3;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls013( )
      {
         standaloneModal013( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel013( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(4);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart013( )
      {
         /* Scan By routine */
         /* Using cursor T000132 */
         pr_default.execute(30, new Object[] {A1AmGecod});
         RcdFound3 = 0;
         if ( (pr_default.getStatus(30) != 101) )
         {
            RcdFound3 = 1;
            A4AmgeSec2 = T000132_A4AmgeSec2[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext013( )
      {
         /* Scan next routine */
         pr_default.readNext(30);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(30) != 101) )
         {
            RcdFound3 = 1;
            A4AmgeSec2 = T000132_A4AmgeSec2[0];
         }
      }

      protected void ScanEnd013( )
      {
         pr_default.close(30);
      }

      protected void AfterConfirm013( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert013( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate013( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete013( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete013( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate013( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes013( )
      {
         edtAmgeSec2_Enabled = 0;
         AssignProp("", false, edtAmgeSec2_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeSec2_Enabled), 5, 0), !bGXsfl_97_Refreshing);
         edtAmgeNoPesIni_Enabled = 0;
         AssignProp("", false, edtAmgeNoPesIni_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeNoPesIni_Enabled), 5, 0), !bGXsfl_97_Refreshing);
         edtAmgeNoPesTer_Enabled = 0;
         AssignProp("", false, edtAmgeNoPesTer_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeNoPesTer_Enabled), 5, 0), !bGXsfl_97_Refreshing);
         edtAmgeValPago_Enabled = 0;
         AssignProp("", false, edtAmgeValPago_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeValPago_Enabled), 5, 0), !bGXsfl_97_Refreshing);
      }

      protected void send_integrity_lvl_hashes013( )
      {
      }

      protected void ZM014( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z30AmGeMail = T00015_A30AmGeMail[0];
            }
            else
            {
               Z30AmGeMail = A30AmGeMail;
            }
         }
         if ( GX_JID == -6 )
         {
            Z1AmGecod = A1AmGecod;
            Z5AmGeSec = A5AmGeSec;
            Z30AmGeMail = A30AmGeMail;
         }
      }

      protected void standaloneNotModal014( )
      {
      }

      protected void standaloneModal014( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtAmGeSec_Enabled = 0;
            AssignProp("", false, edtAmGeSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeSec_Enabled), 5, 0), !bGXsfl_91_Refreshing);
         }
         else
         {
            edtAmGeSec_Enabled = 1;
            AssignProp("", false, edtAmGeSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeSec_Enabled), 5, 0), !bGXsfl_91_Refreshing);
         }
      }

      protected void Load014( )
      {
         /* Using cursor T000133 */
         pr_default.execute(31, new Object[] {A1AmGecod, A5AmGeSec});
         if ( (pr_default.getStatus(31) != 101) )
         {
            RcdFound4 = 1;
            A30AmGeMail = T000133_A30AmGeMail[0];
            n30AmGeMail = T000133_n30AmGeMail[0];
            ZM014( -6) ;
         }
         pr_default.close(31);
         OnLoadActions014( ) ;
      }

      protected void OnLoadActions014( )
      {
      }

      protected void CheckExtendedTable014( )
      {
         nIsDirty_4 = 0;
         Gx_BScreen = 1;
         standaloneModal014( ) ;
      }

      protected void CloseExtendedTableCursors014( )
      {
      }

      protected void enableDisable014( )
      {
      }

      protected void GetKey014( )
      {
         /* Using cursor T000134 */
         pr_default.execute(32, new Object[] {A1AmGecod, A5AmGeSec});
         if ( (pr_default.getStatus(32) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(32);
      }

      protected void getByPrimaryKey014( )
      {
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {A1AmGecod, A5AmGeSec});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM014( 6) ;
            RcdFound4 = 1;
            InitializeNonKey014( ) ;
            A5AmGeSec = T00015_A5AmGeSec[0];
            A30AmGeMail = T00015_A30AmGeMail[0];
            n30AmGeMail = T00015_n30AmGeMail[0];
            Z1AmGecod = A1AmGecod;
            Z5AmGeSec = A5AmGeSec;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal014( ) ;
            Load014( ) ;
            Gx_mode = sMode4;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey014( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal014( ) ;
            Gx_mode = sMode4;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes014( ) ;
         }
         pr_default.close(3);
      }

      protected void CheckOptimisticConcurrency014( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00014 */
            pr_default.execute(2, new Object[] {A1AmGecod, A5AmGeSec});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"agAmGe1"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z30AmGeMail, T00014_A30AmGeMail[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z30AmGeMail, T00014_A30AmGeMail[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmGeMail");
                  GXUtil.WriteLogRaw("Old: ",Z30AmGeMail);
                  GXUtil.WriteLogRaw("Current: ",T00014_A30AmGeMail[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"agAmGe1"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert014( )
      {
         BeforeValidate014( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable014( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM014( 0) ;
            CheckOptimisticConcurrency014( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm014( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert014( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000135 */
                     pr_default.execute(33, new Object[] {A1AmGecod, A5AmGeSec, n30AmGeMail, A30AmGeMail});
                     pr_default.close(33);
                     dsDefault.SmartCacheProvider.SetUpdated("agAmGe1") ;
                     if ( (pr_default.getStatus(33) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load014( ) ;
            }
            EndLevel014( ) ;
         }
         CloseExtendedTableCursors014( ) ;
      }

      protected void Update014( )
      {
         BeforeValidate014( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable014( ) ;
         }
         if ( ( nIsMod_4 != 0 ) || ( nIsDirty_4 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency014( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm014( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate014( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Using cursor T000136 */
                        pr_default.execute(34, new Object[] {n30AmGeMail, A30AmGeMail, A1AmGecod, A5AmGeSec});
                        pr_default.close(34);
                        dsDefault.SmartCacheProvider.SetUpdated("agAmGe1") ;
                        if ( (pr_default.getStatus(34) == 103) )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"agAmGe1"}), "RecordIsLocked", 1, "");
                           AnyError = 1;
                        }
                        DeferredUpdate014( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey014( ) ;
                           }
                        }
                        else
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                           AnyError = 1;
                        }
                     }
                  }
               }
               EndLevel014( ) ;
            }
         }
         CloseExtendedTableCursors014( ) ;
      }

      protected void DeferredUpdate014( )
      {
      }

      protected void Delete014( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate014( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency014( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls014( ) ;
            AfterConfirm014( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete014( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000137 */
                  pr_default.execute(35, new Object[] {A1AmGecod, A5AmGeSec});
                  pr_default.close(35);
                  dsDefault.SmartCacheProvider.SetUpdated("agAmGe1") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel014( ) ;
         Gx_mode = sMode4;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls014( )
      {
         standaloneModal014( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel014( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(2);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart014( )
      {
         /* Scan By routine */
         /* Using cursor T000138 */
         pr_default.execute(36, new Object[] {A1AmGecod});
         RcdFound4 = 0;
         if ( (pr_default.getStatus(36) != 101) )
         {
            RcdFound4 = 1;
            A5AmGeSec = T000138_A5AmGeSec[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext014( )
      {
         /* Scan next routine */
         pr_default.readNext(36);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(36) != 101) )
         {
            RcdFound4 = 1;
            A5AmGeSec = T000138_A5AmGeSec[0];
         }
      }

      protected void ScanEnd014( )
      {
         pr_default.close(36);
      }

      protected void AfterConfirm014( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert014( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate014( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete014( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete014( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate014( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes014( )
      {
         edtAmGeSec_Enabled = 0;
         AssignProp("", false, edtAmGeSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeSec_Enabled), 5, 0), !bGXsfl_91_Refreshing);
         edtAmGeMail_Enabled = 0;
         AssignProp("", false, edtAmGeMail_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeMail_Enabled), 5, 0), !bGXsfl_91_Refreshing);
      }

      protected void send_integrity_lvl_hashes014( )
      {
      }

      protected void ZM016( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z44AmGeMailPort = T00013_A44AmGeMailPort[0];
               Z45AmGeMailHost = T00013_A45AmGeMailHost[0];
               Z46AmGeMailSender = T00013_A46AmGeMailSender[0];
               Z47AmgeMailUser = T00013_A47AmgeMailUser[0];
               Z48AmgeMailPassword = T00013_A48AmgeMailPassword[0];
               Z49AmgeMailAuthentication = T00013_A49AmgeMailAuthentication[0];
               Z50AmgeMailSecure = T00013_A50AmgeMailSecure[0];
               Z51AmgeMailEstado = T00013_A51AmgeMailEstado[0];
            }
            else
            {
               Z44AmGeMailPort = A44AmGeMailPort;
               Z45AmGeMailHost = A45AmGeMailHost;
               Z46AmGeMailSender = A46AmGeMailSender;
               Z47AmgeMailUser = A47AmgeMailUser;
               Z48AmgeMailPassword = A48AmgeMailPassword;
               Z49AmgeMailAuthentication = A49AmgeMailAuthentication;
               Z50AmgeMailSecure = A50AmgeMailSecure;
               Z51AmgeMailEstado = A51AmgeMailEstado;
            }
         }
         if ( GX_JID == -7 )
         {
            Z1AmGecod = A1AmGecod;
            Z43AmGeMailSec = A43AmGeMailSec;
            Z44AmGeMailPort = A44AmGeMailPort;
            Z45AmGeMailHost = A45AmGeMailHost;
            Z46AmGeMailSender = A46AmGeMailSender;
            Z47AmgeMailUser = A47AmgeMailUser;
            Z48AmgeMailPassword = A48AmgeMailPassword;
            Z49AmgeMailAuthentication = A49AmgeMailAuthentication;
            Z50AmgeMailSecure = A50AmgeMailSecure;
            Z51AmgeMailEstado = A51AmgeMailEstado;
         }
      }

      protected void standaloneNotModal016( )
      {
      }

      protected void standaloneModal016( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtAmGeMailSec_Enabled = 0;
            AssignProp("", false, edtAmGeMailSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeMailSec_Enabled), 5, 0), !bGXsfl_114_Refreshing);
         }
         else
         {
            edtAmGeMailSec_Enabled = 1;
            AssignProp("", false, edtAmGeMailSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeMailSec_Enabled), 5, 0), !bGXsfl_114_Refreshing);
         }
      }

      protected void Load016( )
      {
         /* Using cursor T000139 */
         pr_default.execute(37, new Object[] {A1AmGecod, A43AmGeMailSec});
         if ( (pr_default.getStatus(37) != 101) )
         {
            RcdFound6 = 1;
            A44AmGeMailPort = T000139_A44AmGeMailPort[0];
            A45AmGeMailHost = T000139_A45AmGeMailHost[0];
            A46AmGeMailSender = T000139_A46AmGeMailSender[0];
            A47AmgeMailUser = T000139_A47AmgeMailUser[0];
            A48AmgeMailPassword = T000139_A48AmgeMailPassword[0];
            A49AmgeMailAuthentication = T000139_A49AmgeMailAuthentication[0];
            A50AmgeMailSecure = T000139_A50AmgeMailSecure[0];
            A51AmgeMailEstado = T000139_A51AmgeMailEstado[0];
            ZM016( -7) ;
         }
         pr_default.close(37);
         OnLoadActions016( ) ;
      }

      protected void OnLoadActions016( )
      {
      }

      protected void CheckExtendedTable016( )
      {
         nIsDirty_6 = 0;
         Gx_BScreen = 1;
         standaloneModal016( ) ;
      }

      protected void CloseExtendedTableCursors016( )
      {
      }

      protected void enableDisable016( )
      {
      }

      protected void GetKey016( )
      {
         /* Using cursor T000140 */
         pr_default.execute(38, new Object[] {A1AmGecod, A43AmGeMailSec});
         if ( (pr_default.getStatus(38) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(38);
      }

      protected void getByPrimaryKey016( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {A1AmGecod, A43AmGeMailSec});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM016( 7) ;
            RcdFound6 = 1;
            InitializeNonKey016( ) ;
            A43AmGeMailSec = T00013_A43AmGeMailSec[0];
            A44AmGeMailPort = T00013_A44AmGeMailPort[0];
            A45AmGeMailHost = T00013_A45AmGeMailHost[0];
            A46AmGeMailSender = T00013_A46AmGeMailSender[0];
            A47AmgeMailUser = T00013_A47AmgeMailUser[0];
            A48AmgeMailPassword = T00013_A48AmgeMailPassword[0];
            A49AmgeMailAuthentication = T00013_A49AmgeMailAuthentication[0];
            A50AmgeMailSecure = T00013_A50AmgeMailSecure[0];
            A51AmgeMailEstado = T00013_A51AmgeMailEstado[0];
            Z1AmGecod = A1AmGecod;
            Z43AmGeMailSec = A43AmGeMailSec;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal016( ) ;
            Load016( ) ;
            Gx_mode = sMode6;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey016( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal016( ) ;
            Gx_mode = sMode6;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes016( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency016( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00012 */
            pr_default.execute(0, new Object[] {A1AmGecod, A43AmGeMailSec});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AgAmGe4"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z44AmGeMailPort != T00012_A44AmGeMailPort[0] ) || ( StringUtil.StrCmp(Z45AmGeMailHost, T00012_A45AmGeMailHost[0]) != 0 ) || ( StringUtil.StrCmp(Z46AmGeMailSender, T00012_A46AmGeMailSender[0]) != 0 ) || ( StringUtil.StrCmp(Z47AmgeMailUser, T00012_A47AmgeMailUser[0]) != 0 ) || ( StringUtil.StrCmp(Z48AmgeMailPassword, T00012_A48AmgeMailPassword[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z49AmgeMailAuthentication != T00012_A49AmgeMailAuthentication[0] ) || ( Z50AmgeMailSecure != T00012_A50AmgeMailSecure[0] ) || ( StringUtil.StrCmp(Z51AmgeMailEstado, T00012_A51AmgeMailEstado[0]) != 0 ) )
            {
               if ( Z44AmGeMailPort != T00012_A44AmGeMailPort[0] )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmGeMailPort");
                  GXUtil.WriteLogRaw("Old: ",Z44AmGeMailPort);
                  GXUtil.WriteLogRaw("Current: ",T00012_A44AmGeMailPort[0]);
               }
               if ( StringUtil.StrCmp(Z45AmGeMailHost, T00012_A45AmGeMailHost[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmGeMailHost");
                  GXUtil.WriteLogRaw("Old: ",Z45AmGeMailHost);
                  GXUtil.WriteLogRaw("Current: ",T00012_A45AmGeMailHost[0]);
               }
               if ( StringUtil.StrCmp(Z46AmGeMailSender, T00012_A46AmGeMailSender[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmGeMailSender");
                  GXUtil.WriteLogRaw("Old: ",Z46AmGeMailSender);
                  GXUtil.WriteLogRaw("Current: ",T00012_A46AmGeMailSender[0]);
               }
               if ( StringUtil.StrCmp(Z47AmgeMailUser, T00012_A47AmgeMailUser[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeMailUser");
                  GXUtil.WriteLogRaw("Old: ",Z47AmgeMailUser);
                  GXUtil.WriteLogRaw("Current: ",T00012_A47AmgeMailUser[0]);
               }
               if ( StringUtil.StrCmp(Z48AmgeMailPassword, T00012_A48AmgeMailPassword[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeMailPassword");
                  GXUtil.WriteLogRaw("Old: ",Z48AmgeMailPassword);
                  GXUtil.WriteLogRaw("Current: ",T00012_A48AmgeMailPassword[0]);
               }
               if ( Z49AmgeMailAuthentication != T00012_A49AmgeMailAuthentication[0] )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeMailAuthentication");
                  GXUtil.WriteLogRaw("Old: ",Z49AmgeMailAuthentication);
                  GXUtil.WriteLogRaw("Current: ",T00012_A49AmgeMailAuthentication[0]);
               }
               if ( Z50AmgeMailSecure != T00012_A50AmgeMailSecure[0] )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeMailSecure");
                  GXUtil.WriteLogRaw("Old: ",Z50AmgeMailSecure);
                  GXUtil.WriteLogRaw("Current: ",T00012_A50AmgeMailSecure[0]);
               }
               if ( StringUtil.StrCmp(Z51AmgeMailEstado, T00012_A51AmgeMailEstado[0]) != 0 )
               {
                  GXUtil.WriteLog("tagamge:[seudo value changed for attri]"+"AmgeMailEstado");
                  GXUtil.WriteLogRaw("Old: ",Z51AmgeMailEstado);
                  GXUtil.WriteLogRaw("Current: ",T00012_A51AmgeMailEstado[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"AgAmGe4"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert016( )
      {
         BeforeValidate016( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable016( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM016( 0) ;
            CheckOptimisticConcurrency016( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm016( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert016( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000141 */
                     pr_default.execute(39, new Object[] {A1AmGecod, A43AmGeMailSec, A44AmGeMailPort, A45AmGeMailHost, A46AmGeMailSender, A47AmgeMailUser, A48AmgeMailPassword, A49AmgeMailAuthentication, A50AmgeMailSecure, A51AmgeMailEstado});
                     pr_default.close(39);
                     dsDefault.SmartCacheProvider.SetUpdated("AgAmGe4") ;
                     if ( (pr_default.getStatus(39) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load016( ) ;
            }
            EndLevel016( ) ;
         }
         CloseExtendedTableCursors016( ) ;
      }

      protected void Update016( )
      {
         BeforeValidate016( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable016( ) ;
         }
         if ( ( nIsMod_6 != 0 ) || ( nIsDirty_6 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency016( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm016( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate016( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Using cursor T000142 */
                        pr_default.execute(40, new Object[] {A44AmGeMailPort, A45AmGeMailHost, A46AmGeMailSender, A47AmgeMailUser, A48AmgeMailPassword, A49AmgeMailAuthentication, A50AmgeMailSecure, A51AmgeMailEstado, A1AmGecod, A43AmGeMailSec});
                        pr_default.close(40);
                        dsDefault.SmartCacheProvider.SetUpdated("AgAmGe4") ;
                        if ( (pr_default.getStatus(40) == 103) )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AgAmGe4"}), "RecordIsLocked", 1, "");
                           AnyError = 1;
                        }
                        DeferredUpdate016( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey016( ) ;
                           }
                        }
                        else
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                           AnyError = 1;
                        }
                     }
                  }
               }
               EndLevel016( ) ;
            }
         }
         CloseExtendedTableCursors016( ) ;
      }

      protected void DeferredUpdate016( )
      {
      }

      protected void Delete016( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate016( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency016( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls016( ) ;
            AfterConfirm016( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete016( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000143 */
                  pr_default.execute(41, new Object[] {A1AmGecod, A43AmGeMailSec});
                  pr_default.close(41);
                  dsDefault.SmartCacheProvider.SetUpdated("AgAmGe4") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel016( ) ;
         Gx_mode = sMode6;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls016( )
      {
         standaloneModal016( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel016( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart016( )
      {
         /* Scan By routine */
         /* Using cursor T000144 */
         pr_default.execute(42, new Object[] {A1AmGecod});
         RcdFound6 = 0;
         if ( (pr_default.getStatus(42) != 101) )
         {
            RcdFound6 = 1;
            A43AmGeMailSec = T000144_A43AmGeMailSec[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext016( )
      {
         /* Scan next routine */
         pr_default.readNext(42);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(42) != 101) )
         {
            RcdFound6 = 1;
            A43AmGeMailSec = T000144_A43AmGeMailSec[0];
         }
      }

      protected void ScanEnd016( )
      {
         pr_default.close(42);
      }

      protected void AfterConfirm016( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert016( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate016( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete016( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete016( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate016( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes016( )
      {
         edtAmGeMailSec_Enabled = 0;
         AssignProp("", false, edtAmGeMailSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeMailSec_Enabled), 5, 0), !bGXsfl_114_Refreshing);
         chkAmgeMailSecure.Enabled = 0;
         AssignProp("", false, chkAmgeMailSecure_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(chkAmgeMailSecure.Enabled), 5, 0), !bGXsfl_114_Refreshing);
      }

      protected void send_integrity_lvl_hashes016( )
      {
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void SubsflControlProps_1042( )
      {
         edtAmgewsSec_Internalname = "AMGEWSSEC_"+sGXsfl_104_idx;
         edtAmgeWsPort_Internalname = "AMGEWSPORT_"+sGXsfl_104_idx;
         edtAmgeWsHost_Internalname = "AMGEWSHOST_"+sGXsfl_104_idx;
         edtAmgeWsUri_Internalname = "AMGEWSURI_"+sGXsfl_104_idx;
         edtAmgeWsLoc_Internalname = "AMGEWSLOC_"+sGXsfl_104_idx;
         edtAmgeWsTip_Internalname = "AMGEWSTIP_"+sGXsfl_104_idx;
         edtAmgeWsEst_Internalname = "AMGEWSEST_"+sGXsfl_104_idx;
      }

      protected void SubsflControlProps_fel_1042( )
      {
         edtAmgewsSec_Internalname = "AMGEWSSEC_"+sGXsfl_104_fel_idx;
         edtAmgeWsPort_Internalname = "AMGEWSPORT_"+sGXsfl_104_fel_idx;
         edtAmgeWsHost_Internalname = "AMGEWSHOST_"+sGXsfl_104_fel_idx;
         edtAmgeWsUri_Internalname = "AMGEWSURI_"+sGXsfl_104_fel_idx;
         edtAmgeWsLoc_Internalname = "AMGEWSLOC_"+sGXsfl_104_fel_idx;
         edtAmgeWsTip_Internalname = "AMGEWSTIP_"+sGXsfl_104_fel_idx;
         edtAmgeWsEst_Internalname = "AMGEWSEST_"+sGXsfl_104_fel_idx;
      }

      protected void AddRow012( )
      {
         nGXsfl_104_idx = (int)(nGXsfl_104_idx+1);
         sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_104_idx), 4, 0), 4, "0");
         SubsflControlProps_1042( ) ;
         SendRow012( ) ;
      }

      protected void SendRow012( )
      {
         Grid3Row = GXWebRow.GetNew(context);
         if ( subGrid3_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid3_Backstyle = 0;
            if ( StringUtil.StrCmp(subGrid3_Class, "") != 0 )
            {
               subGrid3_Linesclass = subGrid3_Class+"Odd";
            }
         }
         else if ( subGrid3_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid3_Backstyle = 0;
            subGrid3_Backcolor = subGrid3_Allbackcolor;
            if ( StringUtil.StrCmp(subGrid3_Class, "") != 0 )
            {
               subGrid3_Linesclass = subGrid3_Class+"Uniform";
            }
         }
         else if ( subGrid3_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid3_Backstyle = 1;
            if ( StringUtil.StrCmp(subGrid3_Class, "") != 0 )
            {
               subGrid3_Linesclass = subGrid3_Class+"Odd";
            }
            subGrid3_Backcolor = (int)(0x0);
         }
         else if ( subGrid3_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid3_Backstyle = 1;
            if ( ((int)((nGXsfl_104_idx) % (2))) == 0 )
            {
               subGrid3_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid3_Class, "") != 0 )
               {
                  subGrid3_Linesclass = subGrid3_Class+"Even";
               }
            }
            else
            {
               subGrid3_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid3_Class, "") != 0 )
               {
                  subGrid3_Linesclass = subGrid3_Class+"Odd";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_104_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 105,'',false,'" + sGXsfl_104_idx + "',104)\"";
         ROClassString = "Attribute";
         Grid3Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgewsSec_Internalname,StringUtil.RTrim( A3AmgewsSec),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,105);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgewsSec_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmgewsSec_Enabled,(short)1,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)104,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_104_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 106,'',false,'" + sGXsfl_104_idx + "',104)\"";
         ROClassString = "Attribute";
         Grid3Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeWsPort_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A21AmgeWsPort), 4, 0, ",", "")),((edtAmgeWsPort_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A21AmgeWsPort), "ZZZ9")) : context.localUtil.Format( (decimal)(A21AmgeWsPort), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,106);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeWsPort_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmgeWsPort_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)104,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_104_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 107,'',false,'" + sGXsfl_104_idx + "',104)\"";
         ROClassString = "Attribute";
         Grid3Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeWsHost_Internalname,StringUtil.RTrim( A22AmgeWsHost),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,107);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeWsHost_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmgeWsHost_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)104,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_104_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 108,'',false,'" + sGXsfl_104_idx + "',104)\"";
         ROClassString = "Attribute";
         Grid3Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeWsUri_Internalname,(String)A23AmgeWsUri,(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,108);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeWsUri_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmgeWsUri_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)300,(short)0,(short)0,(short)104,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_104_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 109,'',false,'" + sGXsfl_104_idx + "',104)\"";
         ROClassString = "Attribute";
         Grid3Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeWsLoc_Internalname,StringUtil.RTrim( A24AmgeWsLoc),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,109);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeWsLoc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmgeWsLoc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)104,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_104_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 110,'',false,'" + sGXsfl_104_idx + "',104)\"";
         ROClassString = "Attribute";
         Grid3Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeWsTip_Internalname,StringUtil.RTrim( A25AmgeWsTip),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,110);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeWsTip_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmgeWsTip_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)104,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_104_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 111,'',false,'" + sGXsfl_104_idx + "',104)\"";
         ROClassString = "Attribute";
         Grid3Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeWsEst_Internalname,StringUtil.RTrim( A26AmgeWsEst),StringUtil.RTrim( context.localUtil.Format( A26AmgeWsEst, "!")),TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(this,111);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeWsEst_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmgeWsEst_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)104,(short)1,(short)-1,(short)-1,(bool)true,(String)"Calificacion",(String)"left",(bool)true,(String)""});
         context.httpAjaxContext.ajax_sending_grid_row(Grid3Row);
         send_integrity_lvl_hashes012( ) ;
         GXCCtl = "Z3AmgewsSec_" + sGXsfl_104_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z3AmgewsSec));
         GXCCtl = "Z21AmgeWsPort_" + sGXsfl_104_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z21AmgeWsPort), 4, 0, ",", "")));
         GXCCtl = "Z22AmgeWsHost_" + sGXsfl_104_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z22AmgeWsHost));
         GXCCtl = "Z23AmgeWsUri_" + sGXsfl_104_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, Z23AmgeWsUri);
         GXCCtl = "Z24AmgeWsLoc_" + sGXsfl_104_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z24AmgeWsLoc));
         GXCCtl = "Z25AmgeWsTip_" + sGXsfl_104_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z25AmgeWsTip));
         GXCCtl = "Z26AmgeWsEst_" + sGXsfl_104_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z26AmgeWsEst));
         GXCCtl = "nRcdDeleted_2_" + sGXsfl_104_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_2_" + sGXsfl_104_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ",", "")));
         GXCCtl = "nIsMod_2_" + sGXsfl_104_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "AMGEWSSEC_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgewsSec_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "AMGEWSPORT_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsPort_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "AMGEWSHOST_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsHost_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "AMGEWSURI_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsUri_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "AMGEWSLOC_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsLoc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "AMGEWSTIP_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsTip_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "AMGEWSEST_"+sGXsfl_104_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeWsEst_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Grid3Container.AddRow(Grid3Row);
      }

      protected void ReadRow012( )
      {
         nGXsfl_104_idx = (int)(nGXsfl_104_idx+1);
         sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_104_idx), 4, 0), 4, "0");
         SubsflControlProps_1042( ) ;
         edtAmgewsSec_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSSEC_"+sGXsfl_104_idx+"Enabled"), ",", "."));
         edtAmgeWsPort_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSPORT_"+sGXsfl_104_idx+"Enabled"), ",", "."));
         edtAmgeWsHost_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSHOST_"+sGXsfl_104_idx+"Enabled"), ",", "."));
         edtAmgeWsUri_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSURI_"+sGXsfl_104_idx+"Enabled"), ",", "."));
         edtAmgeWsLoc_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSLOC_"+sGXsfl_104_idx+"Enabled"), ",", "."));
         edtAmgeWsTip_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSTIP_"+sGXsfl_104_idx+"Enabled"), ",", "."));
         edtAmgeWsEst_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEWSEST_"+sGXsfl_104_idx+"Enabled"), ",", "."));
         A3AmgewsSec = cgiGet( edtAmgewsSec_Internalname);
         if ( ( ( context.localUtil.CToN( cgiGet( edtAmgeWsPort_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAmgeWsPort_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "AMGEWSPORT_" + sGXsfl_104_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtAmgeWsPort_Internalname;
            wbErr = true;
            A21AmgeWsPort = 0;
         }
         else
         {
            A21AmgeWsPort = (short)(context.localUtil.CToN( cgiGet( edtAmgeWsPort_Internalname), ",", "."));
         }
         A22AmgeWsHost = cgiGet( edtAmgeWsHost_Internalname);
         A23AmgeWsUri = cgiGet( edtAmgeWsUri_Internalname);
         A24AmgeWsLoc = cgiGet( edtAmgeWsLoc_Internalname);
         A25AmgeWsTip = cgiGet( edtAmgeWsTip_Internalname);
         A26AmgeWsEst = StringUtil.Upper( cgiGet( edtAmgeWsEst_Internalname));
         GXCCtl = "Z3AmgewsSec_" + sGXsfl_104_idx;
         Z3AmgewsSec = cgiGet( GXCCtl);
         GXCCtl = "Z21AmgeWsPort_" + sGXsfl_104_idx;
         Z21AmgeWsPort = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z22AmgeWsHost_" + sGXsfl_104_idx;
         Z22AmgeWsHost = cgiGet( GXCCtl);
         GXCCtl = "Z23AmgeWsUri_" + sGXsfl_104_idx;
         Z23AmgeWsUri = cgiGet( GXCCtl);
         GXCCtl = "Z24AmgeWsLoc_" + sGXsfl_104_idx;
         Z24AmgeWsLoc = cgiGet( GXCCtl);
         GXCCtl = "Z25AmgeWsTip_" + sGXsfl_104_idx;
         Z25AmgeWsTip = cgiGet( GXCCtl);
         GXCCtl = "Z26AmgeWsEst_" + sGXsfl_104_idx;
         Z26AmgeWsEst = cgiGet( GXCCtl);
         GXCCtl = "nRcdDeleted_2_" + sGXsfl_104_idx;
         nRcdDeleted_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_2_" + sGXsfl_104_idx;
         nRcdExists_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_2_" + sGXsfl_104_idx;
         nIsMod_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void SubsflControlProps_973( )
      {
         edtAmgeSec2_Internalname = "AMGESEC2_"+sGXsfl_97_idx;
         edtAmgeNoPesIni_Internalname = "AMGENOPESINI_"+sGXsfl_97_idx;
         edtAmgeNoPesTer_Internalname = "AMGENOPESTER_"+sGXsfl_97_idx;
         edtAmgeValPago_Internalname = "AMGEVALPAGO_"+sGXsfl_97_idx;
      }

      protected void SubsflControlProps_fel_973( )
      {
         edtAmgeSec2_Internalname = "AMGESEC2_"+sGXsfl_97_fel_idx;
         edtAmgeNoPesIni_Internalname = "AMGENOPESINI_"+sGXsfl_97_fel_idx;
         edtAmgeNoPesTer_Internalname = "AMGENOPESTER_"+sGXsfl_97_fel_idx;
         edtAmgeValPago_Internalname = "AMGEVALPAGO_"+sGXsfl_97_fel_idx;
      }

      protected void AddRow013( )
      {
         nGXsfl_97_idx = (int)(nGXsfl_97_idx+1);
         sGXsfl_97_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_97_idx), 4, 0), 4, "0");
         SubsflControlProps_973( ) ;
         SendRow013( ) ;
      }

      protected void SendRow013( )
      {
         Grid2Row = GXWebRow.GetNew(context);
         if ( subGrid2_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid2_Backstyle = 0;
            if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
            {
               subGrid2_Linesclass = subGrid2_Class+"Odd";
            }
         }
         else if ( subGrid2_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid2_Backstyle = 0;
            subGrid2_Backcolor = subGrid2_Allbackcolor;
            if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
            {
               subGrid2_Linesclass = subGrid2_Class+"Uniform";
            }
         }
         else if ( subGrid2_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid2_Backstyle = 1;
            if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
            {
               subGrid2_Linesclass = subGrid2_Class+"Odd";
            }
            subGrid2_Backcolor = (int)(0x0);
         }
         else if ( subGrid2_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid2_Backstyle = 1;
            if ( ((int)((nGXsfl_97_idx) % (2))) == 0 )
            {
               subGrid2_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
               {
                  subGrid2_Linesclass = subGrid2_Class+"Even";
               }
            }
            else
            {
               subGrid2_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
               {
                  subGrid2_Linesclass = subGrid2_Class+"Odd";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_3_" + sGXsfl_97_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 98,'',false,'" + sGXsfl_97_idx + "',97)\"";
         ROClassString = "Attribute";
         Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeSec2_Internalname,StringUtil.RTrim( A4AmgeSec2),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,98);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeSec2_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmgeSec2_Enabled,(short)1,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)97,(short)1,(short)-1,(short)-1,(bool)true,(String)"codcorto",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_3_" + sGXsfl_97_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 99,'',false,'" + sGXsfl_97_idx + "',97)\"";
         ROClassString = "Attribute";
         Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeNoPesIni_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A27AmgeNoPesIni), 4, 0, ",", "")),((edtAmgeNoPesIni_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A27AmgeNoPesIni), "ZZZ9")) : context.localUtil.Format( (decimal)(A27AmgeNoPesIni), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,99);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeNoPesIni_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmgeNoPesIni_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)97,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_3_" + sGXsfl_97_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 100,'',false,'" + sGXsfl_97_idx + "',97)\"";
         ROClassString = "Attribute";
         Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeNoPesTer_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A28AmgeNoPesTer), 4, 0, ",", "")),((edtAmgeNoPesTer_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A28AmgeNoPesTer), "ZZZ9")) : context.localUtil.Format( (decimal)(A28AmgeNoPesTer), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,100);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeNoPesTer_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmgeNoPesTer_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)97,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_3_" + sGXsfl_97_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 101,'',false,'" + sGXsfl_97_idx + "',97)\"";
         ROClassString = "Attribute";
         Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmgeValPago_Internalname,StringUtil.LTrim( StringUtil.NToC( A29AmgeValPago, 9, 2, ",", "")),((edtAmgeValPago_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A29AmgeValPago, "ZZ,ZZ9.99")) : context.localUtil.Format( A29AmgeValPago, "ZZ,ZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onblur(this,101);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmgeValPago_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmgeValPago_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)97,(short)1,(short)-1,(short)0,(bool)true,(String)"valcorto",(String)"right",(bool)false,(String)""});
         context.httpAjaxContext.ajax_sending_grid_row(Grid2Row);
         send_integrity_lvl_hashes013( ) ;
         GXCCtl = "Z4AmgeSec2_" + sGXsfl_97_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z4AmgeSec2));
         GXCCtl = "Z27AmgeNoPesIni_" + sGXsfl_97_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27AmgeNoPesIni), 4, 0, ",", "")));
         GXCCtl = "Z28AmgeNoPesTer_" + sGXsfl_97_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z28AmgeNoPesTer), 4, 0, ",", "")));
         GXCCtl = "Z29AmgeValPago_" + sGXsfl_97_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z29AmgeValPago, 8, 2, ",", "")));
         GXCCtl = "nRcdDeleted_3_" + sGXsfl_97_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_3), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_3_" + sGXsfl_97_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_3), 4, 0, ",", "")));
         GXCCtl = "nIsMod_3_" + sGXsfl_97_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_3), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "AMGESEC2_"+sGXsfl_97_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeSec2_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "AMGENOPESINI_"+sGXsfl_97_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeNoPesIni_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "AMGENOPESTER_"+sGXsfl_97_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeNoPesTer_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "AMGEVALPAGO_"+sGXsfl_97_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmgeValPago_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Grid2Container.AddRow(Grid2Row);
      }

      protected void ReadRow013( )
      {
         nGXsfl_97_idx = (int)(nGXsfl_97_idx+1);
         sGXsfl_97_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_97_idx), 4, 0), 4, "0");
         SubsflControlProps_973( ) ;
         edtAmgeSec2_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGESEC2_"+sGXsfl_97_idx+"Enabled"), ",", "."));
         edtAmgeNoPesIni_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGENOPESINI_"+sGXsfl_97_idx+"Enabled"), ",", "."));
         edtAmgeNoPesTer_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGENOPESTER_"+sGXsfl_97_idx+"Enabled"), ",", "."));
         edtAmgeValPago_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEVALPAGO_"+sGXsfl_97_idx+"Enabled"), ",", "."));
         A4AmgeSec2 = cgiGet( edtAmgeSec2_Internalname);
         if ( ( ( context.localUtil.CToN( cgiGet( edtAmgeNoPesIni_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAmgeNoPesIni_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "AMGENOPESINI_" + sGXsfl_97_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtAmgeNoPesIni_Internalname;
            wbErr = true;
            A27AmgeNoPesIni = 0;
            n27AmgeNoPesIni = false;
         }
         else
         {
            A27AmgeNoPesIni = (short)(context.localUtil.CToN( cgiGet( edtAmgeNoPesIni_Internalname), ",", "."));
            n27AmgeNoPesIni = false;
         }
         n27AmgeNoPesIni = ((0==A27AmgeNoPesIni) ? true : false);
         if ( ( ( context.localUtil.CToN( cgiGet( edtAmgeNoPesTer_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAmgeNoPesTer_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "AMGENOPESTER_" + sGXsfl_97_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtAmgeNoPesTer_Internalname;
            wbErr = true;
            A28AmgeNoPesTer = 0;
            n28AmgeNoPesTer = false;
         }
         else
         {
            A28AmgeNoPesTer = (short)(context.localUtil.CToN( cgiGet( edtAmgeNoPesTer_Internalname), ",", "."));
            n28AmgeNoPesTer = false;
         }
         n28AmgeNoPesTer = ((0==A28AmgeNoPesTer) ? true : false);
         if ( ( ( context.localUtil.CToN( cgiGet( edtAmgeValPago_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAmgeValPago_Internalname), ",", ".") > 99999.99m ) ) )
         {
            GXCCtl = "AMGEVALPAGO_" + sGXsfl_97_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtAmgeValPago_Internalname;
            wbErr = true;
            A29AmgeValPago = 0;
            n29AmgeValPago = false;
         }
         else
         {
            A29AmgeValPago = context.localUtil.CToN( cgiGet( edtAmgeValPago_Internalname), ",", ".");
            n29AmgeValPago = false;
         }
         n29AmgeValPago = ((Convert.ToDecimal(0)==A29AmgeValPago) ? true : false);
         GXCCtl = "Z4AmgeSec2_" + sGXsfl_97_idx;
         Z4AmgeSec2 = cgiGet( GXCCtl);
         GXCCtl = "Z27AmgeNoPesIni_" + sGXsfl_97_idx;
         Z27AmgeNoPesIni = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n27AmgeNoPesIni = ((0==A27AmgeNoPesIni) ? true : false);
         GXCCtl = "Z28AmgeNoPesTer_" + sGXsfl_97_idx;
         Z28AmgeNoPesTer = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n28AmgeNoPesTer = ((0==A28AmgeNoPesTer) ? true : false);
         GXCCtl = "Z29AmgeValPago_" + sGXsfl_97_idx;
         Z29AmgeValPago = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n29AmgeValPago = ((Convert.ToDecimal(0)==A29AmgeValPago) ? true : false);
         GXCCtl = "nRcdDeleted_3_" + sGXsfl_97_idx;
         nRcdDeleted_3 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_3_" + sGXsfl_97_idx;
         nRcdExists_3 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_3_" + sGXsfl_97_idx;
         nIsMod_3 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void SubsflControlProps_914( )
      {
         edtavnRcdDeleted_4_Internalname = "vNRCDDELETED_4_"+sGXsfl_91_idx;
         edtAmGeSec_Internalname = "AMGESEC_"+sGXsfl_91_idx;
         edtAmGeMail_Internalname = "AMGEMAIL_"+sGXsfl_91_idx;
      }

      protected void SubsflControlProps_fel_914( )
      {
         edtavnRcdDeleted_4_Internalname = "vNRCDDELETED_4_"+sGXsfl_91_fel_idx;
         edtAmGeSec_Internalname = "AMGESEC_"+sGXsfl_91_fel_idx;
         edtAmGeMail_Internalname = "AMGEMAIL_"+sGXsfl_91_fel_idx;
      }

      protected void AddRow014( )
      {
         nGXsfl_91_idx = (int)(nGXsfl_91_idx+1);
         sGXsfl_91_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_91_idx), 4, 0), 4, "0");
         SubsflControlProps_914( ) ;
         SendRow014( ) ;
      }

      protected void SendRow014( )
      {
         Grid1Row = GXWebRow.GetNew(context);
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
            subGrid1_Backcolor = (int)(0xFFFFFF);
         }
         else if ( subGrid1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid1_Backstyle = 1;
            if ( ((int)((nGXsfl_91_idx) % (2))) == 0 )
            {
               subGrid1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Even";
               }
            }
            else
            {
               subGrid1_Backcolor = (int)(0xFFFFFF);
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_4_" + sGXsfl_91_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 92,'',false,'" + sGXsfl_91_idx + "',91)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavnRcdDeleted_4_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_4), 4, 0, ",", "")),((edtavnRcdDeleted_4_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(nRcdDeleted_4), "9999")) : context.localUtil.Format( (decimal)(nRcdDeleted_4), "9999")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,92);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavnRcdDeleted_4_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtavnRcdDeleted_4_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)91,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_4_" + sGXsfl_91_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 93,'',false,'" + sGXsfl_91_idx + "',91)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGeSec_Internalname,StringUtil.RTrim( A5AmGeSec),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,93);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmGeSec_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmGeSec_Enabled,(short)1,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)91,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_4_" + sGXsfl_91_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 94,'',false,'" + sGXsfl_91_idx + "',91)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGeMail_Internalname,StringUtil.RTrim( A30AmGeMail),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,94);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmGeMail_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmGeMail_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)91,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         context.httpAjaxContext.ajax_sending_grid_row(Grid1Row);
         send_integrity_lvl_hashes014( ) ;
         GXCCtl = "Z5AmGeSec_" + sGXsfl_91_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z5AmGeSec));
         GXCCtl = "Z30AmGeMail_" + sGXsfl_91_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z30AmGeMail));
         GXCCtl = "nRcdDeleted_4_" + sGXsfl_91_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_4), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_4_" + sGXsfl_91_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_4), 4, 0, ",", "")));
         GXCCtl = "nIsMod_4_" + sGXsfl_91_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_4), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vNRCDDELETED_4_"+sGXsfl_91_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavnRcdDeleted_4_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "AMGESEC_"+sGXsfl_91_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmGeSec_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "AMGEMAIL_"+sGXsfl_91_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmGeMail_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Grid1Container.AddRow(Grid1Row);
      }

      protected void ReadRow014( )
      {
         nGXsfl_91_idx = (int)(nGXsfl_91_idx+1);
         sGXsfl_91_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_91_idx), 4, 0), 4, "0");
         SubsflControlProps_914( ) ;
         edtavnRcdDeleted_4_Enabled = (int)(context.localUtil.CToN( cgiGet( "vNRCDDELETED_4_"+sGXsfl_91_idx+"Enabled"), ",", "."));
         edtAmGeSec_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGESEC_"+sGXsfl_91_idx+"Enabled"), ",", "."));
         edtAmGeMail_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEMAIL_"+sGXsfl_91_idx+"Enabled"), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtavnRcdDeleted_4_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavnRcdDeleted_4_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNRCDDELETED_4");
            AnyError = 1;
            GX_FocusControl = edtavnRcdDeleted_4_Internalname;
            wbErr = true;
            nRcdDeleted_4 = 0;
         }
         else
         {
            nRcdDeleted_4 = (short)(context.localUtil.CToN( cgiGet( edtavnRcdDeleted_4_Internalname), ",", "."));
         }
         A5AmGeSec = cgiGet( edtAmGeSec_Internalname);
         A30AmGeMail = cgiGet( edtAmGeMail_Internalname);
         n30AmGeMail = false;
         n30AmGeMail = (String.IsNullOrEmpty(StringUtil.RTrim( A30AmGeMail)) ? true : false);
         GXCCtl = "Z5AmGeSec_" + sGXsfl_91_idx;
         Z5AmGeSec = cgiGet( GXCCtl);
         GXCCtl = "Z30AmGeMail_" + sGXsfl_91_idx;
         Z30AmGeMail = cgiGet( GXCCtl);
         n30AmGeMail = (String.IsNullOrEmpty(StringUtil.RTrim( A30AmGeMail)) ? true : false);
         GXCCtl = "nRcdDeleted_4_" + sGXsfl_91_idx;
         nRcdDeleted_4 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_4_" + sGXsfl_91_idx;
         nRcdExists_4 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_4_" + sGXsfl_91_idx;
         nIsMod_4 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void SubsflControlProps_1146( )
      {
         edtAmGeMailSec_Internalname = "AMGEMAILSEC_"+sGXsfl_114_idx;
         chkAmgeMailSecure_Internalname = "AMGEMAILSECURE_"+sGXsfl_114_idx;
      }

      protected void SubsflControlProps_fel_1146( )
      {
         edtAmGeMailSec_Internalname = "AMGEMAILSEC_"+sGXsfl_114_fel_idx;
         chkAmgeMailSecure_Internalname = "AMGEMAILSECURE_"+sGXsfl_114_fel_idx;
      }

      protected void AddRow016( )
      {
         nGXsfl_114_idx = (int)(nGXsfl_114_idx+1);
         sGXsfl_114_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_114_idx), 4, 0), 4, "0");
         SubsflControlProps_1146( ) ;
         SendRow016( ) ;
      }

      protected void SendRow016( )
      {
         Grid4Row = GXWebRow.GetNew(context);
         if ( subGrid4_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid4_Backstyle = 0;
            if ( StringUtil.StrCmp(subGrid4_Class, "") != 0 )
            {
               subGrid4_Linesclass = subGrid4_Class+"Odd";
            }
         }
         else if ( subGrid4_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid4_Backstyle = 0;
            subGrid4_Backcolor = subGrid4_Allbackcolor;
            if ( StringUtil.StrCmp(subGrid4_Class, "") != 0 )
            {
               subGrid4_Linesclass = subGrid4_Class+"Uniform";
            }
         }
         else if ( subGrid4_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid4_Backstyle = 1;
            if ( StringUtil.StrCmp(subGrid4_Class, "") != 0 )
            {
               subGrid4_Linesclass = subGrid4_Class+"Odd";
            }
            subGrid4_Backcolor = (int)(0x0);
         }
         else if ( subGrid4_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid4_Backstyle = 1;
            if ( ((int)((nGXsfl_114_idx) % (2))) == 0 )
            {
               subGrid4_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid4_Class, "") != 0 )
               {
                  subGrid4_Linesclass = subGrid4_Class+"Even";
               }
            }
            else
            {
               subGrid4_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid4_Class, "") != 0 )
               {
                  subGrid4_Linesclass = subGrid4_Class+"Odd";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_6_" + sGXsfl_114_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 115,'',false,'" + sGXsfl_114_idx + "',114)\"";
         ROClassString = "Attribute";
         Grid4Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAmGeMailSec_Internalname,StringUtil.RTrim( A43AmGeMailSec),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,115);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAmGeMailSec_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAmGeMailSec_Enabled,(short)1,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)114,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
         /* Subfile cell */
         /* Check box */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_6_" + sGXsfl_114_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 116,'',false,'" + sGXsfl_114_idx + "',114)\"";
         ClassString = "Attribute";
         StyleString = "";
         GXCCtl = "AMGEMAILSECURE_" + sGXsfl_114_idx;
         chkAmgeMailSecure.Name = GXCCtl;
         chkAmgeMailSecure.WebTags = "";
         chkAmgeMailSecure.Caption = "";
         AssignProp("", false, chkAmgeMailSecure_Internalname, "TitleCaption", chkAmgeMailSecure.Caption, !bGXsfl_114_Refreshing);
         chkAmgeMailSecure.CheckedValue = "false";
         A50AmgeMailSecure = StringUtil.StrToBool( StringUtil.BoolToStr( A50AmgeMailSecure));
         Grid4Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkAmgeMailSecure_Internalname,StringUtil.BoolToStr( A50AmgeMailSecure),(String)"",(String)"",(short)-1,chkAmgeMailSecure.Enabled,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",TempTags+" onclick="+"\"gx.fn.checkboxClick(116, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,116);\""});
         context.httpAjaxContext.ajax_sending_grid_row(Grid4Row);
         send_integrity_lvl_hashes016( ) ;
         GXCCtl = "Z43AmGeMailSec_" + sGXsfl_114_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z43AmGeMailSec));
         GXCCtl = "Z44AmGeMailPort_" + sGXsfl_114_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z44AmGeMailPort), 4, 0, ",", "")));
         GXCCtl = "Z45AmGeMailHost_" + sGXsfl_114_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, Z45AmGeMailHost);
         GXCCtl = "Z46AmGeMailSender_" + sGXsfl_114_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, Z46AmGeMailSender);
         GXCCtl = "Z47AmgeMailUser_" + sGXsfl_114_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, Z47AmgeMailUser);
         GXCCtl = "Z48AmgeMailPassword_" + sGXsfl_114_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, Z48AmgeMailPassword);
         GXCCtl = "Z49AmgeMailAuthentication_" + sGXsfl_114_idx;
         GxWebStd.gx_boolean_hidden_field( context, GXCCtl, Z49AmgeMailAuthentication);
         GXCCtl = "Z50AmgeMailSecure_" + sGXsfl_114_idx;
         GxWebStd.gx_boolean_hidden_field( context, GXCCtl, Z50AmgeMailSecure);
         GXCCtl = "Z51AmgeMailEstado_" + sGXsfl_114_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z51AmgeMailEstado));
         GXCCtl = "nRcdDeleted_6_" + sGXsfl_114_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_6), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_6_" + sGXsfl_114_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_6), 4, 0, ",", "")));
         GXCCtl = "nIsMod_6_" + sGXsfl_114_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_6), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "AMGEMAILSEC_"+sGXsfl_114_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAmGeMailSec_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "AMGEMAILSECURE_"+sGXsfl_114_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkAmgeMailSecure.Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Grid4Container.AddRow(Grid4Row);
      }

      protected void ReadRow016( )
      {
         nGXsfl_114_idx = (int)(nGXsfl_114_idx+1);
         sGXsfl_114_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_114_idx), 4, 0), 4, "0");
         SubsflControlProps_1146( ) ;
         edtAmGeMailSec_Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEMAILSEC_"+sGXsfl_114_idx+"Enabled"), ",", "."));
         chkAmgeMailSecure.Enabled = (int)(context.localUtil.CToN( cgiGet( "AMGEMAILSECURE_"+sGXsfl_114_idx+"Enabled"), ",", "."));
         A43AmGeMailSec = cgiGet( edtAmGeMailSec_Internalname);
         A50AmgeMailSecure = StringUtil.StrToBool( cgiGet( chkAmgeMailSecure_Internalname));
         GXCCtl = "Z43AmGeMailSec_" + sGXsfl_114_idx;
         Z43AmGeMailSec = cgiGet( GXCCtl);
         GXCCtl = "Z44AmGeMailPort_" + sGXsfl_114_idx;
         Z44AmGeMailPort = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z45AmGeMailHost_" + sGXsfl_114_idx;
         Z45AmGeMailHost = cgiGet( GXCCtl);
         GXCCtl = "Z46AmGeMailSender_" + sGXsfl_114_idx;
         Z46AmGeMailSender = cgiGet( GXCCtl);
         GXCCtl = "Z47AmgeMailUser_" + sGXsfl_114_idx;
         Z47AmgeMailUser = cgiGet( GXCCtl);
         GXCCtl = "Z48AmgeMailPassword_" + sGXsfl_114_idx;
         Z48AmgeMailPassword = cgiGet( GXCCtl);
         GXCCtl = "Z49AmgeMailAuthentication_" + sGXsfl_114_idx;
         Z49AmgeMailAuthentication = StringUtil.StrToBool( cgiGet( GXCCtl));
         GXCCtl = "Z50AmgeMailSecure_" + sGXsfl_114_idx;
         Z50AmgeMailSecure = StringUtil.StrToBool( cgiGet( GXCCtl));
         GXCCtl = "Z51AmgeMailEstado_" + sGXsfl_114_idx;
         Z51AmgeMailEstado = cgiGet( GXCCtl);
         GXCCtl = "Z44AmGeMailPort_" + sGXsfl_114_idx;
         A44AmGeMailPort = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z45AmGeMailHost_" + sGXsfl_114_idx;
         A45AmGeMailHost = cgiGet( GXCCtl);
         GXCCtl = "Z46AmGeMailSender_" + sGXsfl_114_idx;
         A46AmGeMailSender = cgiGet( GXCCtl);
         GXCCtl = "Z47AmgeMailUser_" + sGXsfl_114_idx;
         A47AmgeMailUser = cgiGet( GXCCtl);
         GXCCtl = "Z48AmgeMailPassword_" + sGXsfl_114_idx;
         A48AmgeMailPassword = cgiGet( GXCCtl);
         GXCCtl = "Z49AmgeMailAuthentication_" + sGXsfl_114_idx;
         A49AmgeMailAuthentication = StringUtil.StrToBool( cgiGet( GXCCtl));
         GXCCtl = "Z51AmgeMailEstado_" + sGXsfl_114_idx;
         A51AmgeMailEstado = cgiGet( GXCCtl);
         GXCCtl = "nRcdDeleted_6_" + sGXsfl_114_idx;
         nRcdDeleted_6 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_6_" + sGXsfl_114_idx;
         nRcdExists_6 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_6_" + sGXsfl_114_idx;
         nIsMod_6 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtAmGeMailSec_Enabled = edtAmGeMailSec_Enabled;
         defedtAmgewsSec_Enabled = edtAmgewsSec_Enabled;
         defedtAmgeSec2_Enabled = edtAmgeSec2_Enabled;
         defedtAmGeSec_Enabled = edtAmGeSec_Enabled;
      }

      protected void ConfirmValues010( )
      {
         nGXsfl_97_idx = 0;
         sGXsfl_97_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_97_idx), 4, 0), 4, "0");
         SubsflControlProps_973( ) ;
         while ( nGXsfl_97_idx < nRC_GXsfl_97 )
         {
            nGXsfl_97_idx = (int)(nGXsfl_97_idx+1);
            sGXsfl_97_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_97_idx), 4, 0), 4, "0");
            SubsflControlProps_973( ) ;
            ChangePostValue( "Z4AmgeSec2_"+sGXsfl_97_idx, cgiGet( "ZT_"+"Z4AmgeSec2_"+sGXsfl_97_idx)) ;
            DeletePostValue( "ZT_"+"Z4AmgeSec2_"+sGXsfl_97_idx) ;
            ChangePostValue( "Z27AmgeNoPesIni_"+sGXsfl_97_idx, cgiGet( "ZT_"+"Z27AmgeNoPesIni_"+sGXsfl_97_idx)) ;
            DeletePostValue( "ZT_"+"Z27AmgeNoPesIni_"+sGXsfl_97_idx) ;
            ChangePostValue( "Z28AmgeNoPesTer_"+sGXsfl_97_idx, cgiGet( "ZT_"+"Z28AmgeNoPesTer_"+sGXsfl_97_idx)) ;
            DeletePostValue( "ZT_"+"Z28AmgeNoPesTer_"+sGXsfl_97_idx) ;
            ChangePostValue( "Z29AmgeValPago_"+sGXsfl_97_idx, cgiGet( "ZT_"+"Z29AmgeValPago_"+sGXsfl_97_idx)) ;
            DeletePostValue( "ZT_"+"Z29AmgeValPago_"+sGXsfl_97_idx) ;
         }
         nGXsfl_104_idx = 0;
         sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_104_idx), 4, 0), 4, "0");
         SubsflControlProps_1042( ) ;
         while ( nGXsfl_104_idx < nRC_GXsfl_104 )
         {
            nGXsfl_104_idx = (int)(nGXsfl_104_idx+1);
            sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_104_idx), 4, 0), 4, "0");
            SubsflControlProps_1042( ) ;
            ChangePostValue( "Z3AmgewsSec_"+sGXsfl_104_idx, cgiGet( "ZT_"+"Z3AmgewsSec_"+sGXsfl_104_idx)) ;
            DeletePostValue( "ZT_"+"Z3AmgewsSec_"+sGXsfl_104_idx) ;
            ChangePostValue( "Z21AmgeWsPort_"+sGXsfl_104_idx, cgiGet( "ZT_"+"Z21AmgeWsPort_"+sGXsfl_104_idx)) ;
            DeletePostValue( "ZT_"+"Z21AmgeWsPort_"+sGXsfl_104_idx) ;
            ChangePostValue( "Z22AmgeWsHost_"+sGXsfl_104_idx, cgiGet( "ZT_"+"Z22AmgeWsHost_"+sGXsfl_104_idx)) ;
            DeletePostValue( "ZT_"+"Z22AmgeWsHost_"+sGXsfl_104_idx) ;
            ChangePostValue( "Z23AmgeWsUri_"+sGXsfl_104_idx, cgiGet( "ZT_"+"Z23AmgeWsUri_"+sGXsfl_104_idx)) ;
            DeletePostValue( "ZT_"+"Z23AmgeWsUri_"+sGXsfl_104_idx) ;
            ChangePostValue( "Z24AmgeWsLoc_"+sGXsfl_104_idx, cgiGet( "ZT_"+"Z24AmgeWsLoc_"+sGXsfl_104_idx)) ;
            DeletePostValue( "ZT_"+"Z24AmgeWsLoc_"+sGXsfl_104_idx) ;
            ChangePostValue( "Z25AmgeWsTip_"+sGXsfl_104_idx, cgiGet( "ZT_"+"Z25AmgeWsTip_"+sGXsfl_104_idx)) ;
            DeletePostValue( "ZT_"+"Z25AmgeWsTip_"+sGXsfl_104_idx) ;
            ChangePostValue( "Z26AmgeWsEst_"+sGXsfl_104_idx, cgiGet( "ZT_"+"Z26AmgeWsEst_"+sGXsfl_104_idx)) ;
            DeletePostValue( "ZT_"+"Z26AmgeWsEst_"+sGXsfl_104_idx) ;
         }
         nGXsfl_114_idx = 0;
         sGXsfl_114_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_114_idx), 4, 0), 4, "0");
         SubsflControlProps_1146( ) ;
         while ( nGXsfl_114_idx < nRC_GXsfl_114 )
         {
            nGXsfl_114_idx = (int)(nGXsfl_114_idx+1);
            sGXsfl_114_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_114_idx), 4, 0), 4, "0");
            SubsflControlProps_1146( ) ;
            ChangePostValue( "Z43AmGeMailSec_"+sGXsfl_114_idx, cgiGet( "ZT_"+"Z43AmGeMailSec_"+sGXsfl_114_idx)) ;
            DeletePostValue( "ZT_"+"Z43AmGeMailSec_"+sGXsfl_114_idx) ;
            ChangePostValue( "Z44AmGeMailPort_"+sGXsfl_114_idx, cgiGet( "ZT_"+"Z44AmGeMailPort_"+sGXsfl_114_idx)) ;
            DeletePostValue( "ZT_"+"Z44AmGeMailPort_"+sGXsfl_114_idx) ;
            ChangePostValue( "Z45AmGeMailHost_"+sGXsfl_114_idx, cgiGet( "ZT_"+"Z45AmGeMailHost_"+sGXsfl_114_idx)) ;
            DeletePostValue( "ZT_"+"Z45AmGeMailHost_"+sGXsfl_114_idx) ;
            ChangePostValue( "Z46AmGeMailSender_"+sGXsfl_114_idx, cgiGet( "ZT_"+"Z46AmGeMailSender_"+sGXsfl_114_idx)) ;
            DeletePostValue( "ZT_"+"Z46AmGeMailSender_"+sGXsfl_114_idx) ;
            ChangePostValue( "Z47AmgeMailUser_"+sGXsfl_114_idx, cgiGet( "ZT_"+"Z47AmgeMailUser_"+sGXsfl_114_idx)) ;
            DeletePostValue( "ZT_"+"Z47AmgeMailUser_"+sGXsfl_114_idx) ;
            ChangePostValue( "Z48AmgeMailPassword_"+sGXsfl_114_idx, cgiGet( "ZT_"+"Z48AmgeMailPassword_"+sGXsfl_114_idx)) ;
            DeletePostValue( "ZT_"+"Z48AmgeMailPassword_"+sGXsfl_114_idx) ;
            ChangePostValue( "Z49AmgeMailAuthentication_"+sGXsfl_114_idx, cgiGet( "ZT_"+"Z49AmgeMailAuthentication_"+sGXsfl_114_idx)) ;
            DeletePostValue( "ZT_"+"Z49AmgeMailAuthentication_"+sGXsfl_114_idx) ;
            ChangePostValue( "Z50AmgeMailSecure_"+sGXsfl_114_idx, cgiGet( "ZT_"+"Z50AmgeMailSecure_"+sGXsfl_114_idx)) ;
            DeletePostValue( "ZT_"+"Z50AmgeMailSecure_"+sGXsfl_114_idx) ;
            ChangePostValue( "Z51AmgeMailEstado_"+sGXsfl_114_idx, cgiGet( "ZT_"+"Z51AmgeMailEstado_"+sGXsfl_114_idx)) ;
            DeletePostValue( "ZT_"+"Z51AmgeMailEstado_"+sGXsfl_114_idx) ;
         }
         nGXsfl_91_idx = 0;
         sGXsfl_91_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_91_idx), 4, 0), 4, "0");
         SubsflControlProps_914( ) ;
         while ( nGXsfl_91_idx < nRC_GXsfl_91 )
         {
            nGXsfl_91_idx = (int)(nGXsfl_91_idx+1);
            sGXsfl_91_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_91_idx), 4, 0), 4, "0");
            SubsflControlProps_914( ) ;
            ChangePostValue( "Z5AmGeSec_"+sGXsfl_91_idx, cgiGet( "ZT_"+"Z5AmGeSec_"+sGXsfl_91_idx)) ;
            DeletePostValue( "ZT_"+"Z5AmGeSec_"+sGXsfl_91_idx) ;
            ChangePostValue( "Z30AmGeMail_"+sGXsfl_91_idx, cgiGet( "ZT_"+"Z30AmGeMail_"+sGXsfl_91_idx)) ;
            DeletePostValue( "ZT_"+"Z30AmGeMail_"+sGXsfl_91_idx) ;
         }
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
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 144151), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 144151), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 144151), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202242110263887", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 144151), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 144151), false, true);
         context.AddJavascriptSource("calendar-es.js", "?"+context.GetBuildNumber( 144151), false, true);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("tagamge.aspx") +"\">") ;
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
         forbiddenHiddens = new GXProperties();
         forbiddenHiddens.Add("hshsalt", "hsh"+"TagAmGe");
         forbiddenHiddens.Add("AmgeAbr", StringUtil.RTrim( context.localUtil.Format( A20AmgeAbr, "")));
         forbiddenHiddens.Add("AmgeUmedCd", StringUtil.RTrim( context.localUtil.Format( A2AmgeUmedCd, "99999")));
         forbiddenHiddens.Add("AmgeStaGmail", StringUtil.RTrim( context.localUtil.Format( A9AmgeStaGmail, "!")));
         forbiddenHiddens.Add("AmGePswEMail", StringUtil.RTrim( context.localUtil.Format( A10AmGePswEMail, "@!")));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLogInfo("tagamge:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1AmGecod", StringUtil.RTrim( Z1AmGecod));
         GxWebStd.gx_hidden_field( context, "Z7AmGedes", StringUtil.RTrim( Z7AmGedes));
         GxWebStd.gx_hidden_field( context, "Z11AmGeval", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11AmGeval), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z12AmGedet", StringUtil.RTrim( Z12AmGedet));
         GxWebStd.gx_hidden_field( context, "Z20AmgeAbr", StringUtil.RTrim( Z20AmgeAbr));
         GxWebStd.gx_hidden_field( context, "Z8AmGesta", StringUtil.RTrim( Z8AmGesta));
         GxWebStd.gx_hidden_field( context, "Z14AmgeAnio", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14AmgeAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z15AmGeusrlog", StringUtil.RTrim( Z15AmGeusrlog));
         GxWebStd.gx_hidden_field( context, "Z16AmGefeclog", context.localUtil.DToC( Z16AmGefeclog, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z17AmGehralog", StringUtil.RTrim( Z17AmGehralog));
         GxWebStd.gx_hidden_field( context, "Z9AmgeStaGmail", StringUtil.RTrim( Z9AmgeStaGmail));
         GxWebStd.gx_hidden_field( context, "Z10AmGePswEMail", StringUtil.RTrim( Z10AmGePswEMail));
         GxWebStd.gx_hidden_field( context, "Z2AmgeUmedCd", StringUtil.RTrim( Z2AmgeUmedCd));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_104", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_104_idx), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_97", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_97_idx), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_91", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_91_idx), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_114", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_114_idx), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "AMGEABR", StringUtil.RTrim( A20AmgeAbr));
         GxWebStd.gx_hidden_field( context, "AMGESTAGMAIL", StringUtil.RTrim( A9AmgeStaGmail));
         GxWebStd.gx_hidden_field( context, "AMGEPSWEMAIL", StringUtil.RTrim( A10AmGePswEMail));
         GxWebStd.gx_hidden_field( context, "AMGEUMEDCD", StringUtil.RTrim( A2AmgeUmedCd));
         GxWebStd.gx_hidden_field( context, "AMGEUMEDDS", StringUtil.RTrim( A18AmgeUmedDs));
         GxWebStd.gx_hidden_field( context, "AMGEMAILPORT", StringUtil.LTrim( StringUtil.NToC( (decimal)(A44AmGeMailPort), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "AMGEMAILHOST", A45AmGeMailHost);
         GxWebStd.gx_hidden_field( context, "AMGEMAILSENDER", A46AmGeMailSender);
         GxWebStd.gx_hidden_field( context, "AMGEMAILUSER", A47AmgeMailUser);
         GxWebStd.gx_hidden_field( context, "AMGEMAILPASSWORD", A48AmgeMailPassword);
         GxWebStd.gx_boolean_hidden_field( context, "AMGEMAILAUTHENTICATION", A49AmgeMailAuthentication);
         GxWebStd.gx_hidden_field( context, "AMGEMAILESTADO", StringUtil.RTrim( A51AmgeMailEstado));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
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

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
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
         return formatLink("tagamge.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "TagAmGe" ;
      }

      public override String GetPgmdesc( )
      {
         return "Ambiente General" ;
      }

      protected void InitializeNonKey011( )
      {
         A7AmGedes = "";
         n7AmGedes = false;
         AssignAttri("", false, "A7AmGedes", A7AmGedes);
         n7AmGedes = (String.IsNullOrEmpty(StringUtil.RTrim( A7AmGedes)) ? true : false);
         A11AmGeval = 0;
         n11AmGeval = false;
         AssignAttri("", false, "A11AmGeval", StringUtil.LTrimStr( (decimal)(A11AmGeval), 10, 0));
         n11AmGeval = ((0==A11AmGeval) ? true : false);
         A12AmGedet = "";
         n12AmGedet = false;
         AssignAttri("", false, "A12AmGedet", A12AmGedet);
         n12AmGedet = (String.IsNullOrEmpty(StringUtil.RTrim( A12AmGedet)) ? true : false);
         A20AmgeAbr = "";
         n20AmgeAbr = false;
         AssignAttri("", false, "A20AmgeAbr", A20AmgeAbr);
         A8AmGesta = "";
         n8AmGesta = false;
         AssignAttri("", false, "A8AmGesta", A8AmGesta);
         n8AmGesta = (String.IsNullOrEmpty(StringUtil.RTrim( A8AmGesta)) ? true : false);
         A13AmGeobs = "";
         n13AmGeobs = false;
         AssignAttri("", false, "A13AmGeobs", A13AmGeobs);
         n13AmGeobs = (String.IsNullOrEmpty(StringUtil.RTrim( A13AmGeobs)) ? true : false);
         A14AmgeAnio = 0;
         n14AmgeAnio = false;
         AssignAttri("", false, "A14AmgeAnio", StringUtil.LTrimStr( (decimal)(A14AmgeAnio), 4, 0));
         n14AmgeAnio = ((0==A14AmgeAnio) ? true : false);
         A15AmGeusrlog = "";
         n15AmGeusrlog = false;
         AssignAttri("", false, "A15AmGeusrlog", A15AmGeusrlog);
         n15AmGeusrlog = (String.IsNullOrEmpty(StringUtil.RTrim( A15AmGeusrlog)) ? true : false);
         A16AmGefeclog = DateTime.MinValue;
         n16AmGefeclog = false;
         AssignAttri("", false, "A16AmGefeclog", context.localUtil.Format(A16AmGefeclog, "99/99/9999"));
         n16AmGefeclog = ((DateTime.MinValue==A16AmGefeclog) ? true : false);
         A17AmGehralog = "";
         n17AmGehralog = false;
         AssignAttri("", false, "A17AmGehralog", A17AmGehralog);
         n17AmGehralog = (String.IsNullOrEmpty(StringUtil.RTrim( A17AmGehralog)) ? true : false);
         A2AmgeUmedCd = "";
         n2AmgeUmedCd = false;
         AssignAttri("", false, "A2AmgeUmedCd", A2AmgeUmedCd);
         A18AmgeUmedDs = "";
         AssignAttri("", false, "A18AmgeUmedDs", A18AmgeUmedDs);
         A9AmgeStaGmail = "";
         n9AmgeStaGmail = false;
         AssignAttri("", false, "A9AmgeStaGmail", A9AmgeStaGmail);
         A10AmGePswEMail = "";
         n10AmGePswEMail = false;
         AssignAttri("", false, "A10AmGePswEMail", A10AmGePswEMail);
         Z7AmGedes = "";
         Z11AmGeval = 0;
         Z12AmGedet = "";
         Z20AmgeAbr = "";
         Z8AmGesta = "";
         Z14AmgeAnio = 0;
         Z15AmGeusrlog = "";
         Z16AmGefeclog = DateTime.MinValue;
         Z17AmGehralog = "";
         Z9AmgeStaGmail = "";
         Z10AmGePswEMail = "";
         Z2AmgeUmedCd = "";
      }

      protected void InitAll011( )
      {
         A1AmGecod = "";
         AssignAttri("", false, "A1AmGecod", A1AmGecod);
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey012( )
      {
         A21AmgeWsPort = 0;
         A22AmgeWsHost = "";
         A23AmgeWsUri = "";
         A24AmgeWsLoc = "";
         A25AmgeWsTip = "";
         A26AmgeWsEst = "";
         Z21AmgeWsPort = 0;
         Z22AmgeWsHost = "";
         Z23AmgeWsUri = "";
         Z24AmgeWsLoc = "";
         Z25AmgeWsTip = "";
         Z26AmgeWsEst = "";
      }

      protected void InitAll012( )
      {
         A3AmgewsSec = "";
         InitializeNonKey012( ) ;
      }

      protected void StandaloneModalInsert012( )
      {
      }

      protected void InitializeNonKey013( )
      {
         A27AmgeNoPesIni = 0;
         n27AmgeNoPesIni = false;
         A28AmgeNoPesTer = 0;
         n28AmgeNoPesTer = false;
         A29AmgeValPago = 0;
         n29AmgeValPago = false;
         Z27AmgeNoPesIni = 0;
         Z28AmgeNoPesTer = 0;
         Z29AmgeValPago = 0;
      }

      protected void InitAll013( )
      {
         A4AmgeSec2 = "";
         InitializeNonKey013( ) ;
      }

      protected void StandaloneModalInsert013( )
      {
      }

      protected void InitializeNonKey014( )
      {
         A30AmGeMail = "";
         n30AmGeMail = false;
         Z30AmGeMail = "";
      }

      protected void InitAll014( )
      {
         A5AmGeSec = "";
         InitializeNonKey014( ) ;
      }

      protected void StandaloneModalInsert014( )
      {
      }

      protected void InitializeNonKey016( )
      {
         A44AmGeMailPort = 0;
         AssignAttri("", false, "A44AmGeMailPort", StringUtil.LTrimStr( (decimal)(A44AmGeMailPort), 4, 0));
         A45AmGeMailHost = "";
         AssignAttri("", false, "A45AmGeMailHost", A45AmGeMailHost);
         A46AmGeMailSender = "";
         AssignAttri("", false, "A46AmGeMailSender", A46AmGeMailSender);
         A47AmgeMailUser = "";
         AssignAttri("", false, "A47AmgeMailUser", A47AmgeMailUser);
         A48AmgeMailPassword = "";
         AssignAttri("", false, "A48AmgeMailPassword", A48AmgeMailPassword);
         A49AmgeMailAuthentication = false;
         AssignAttri("", false, "A49AmgeMailAuthentication", A49AmgeMailAuthentication);
         A50AmgeMailSecure = false;
         A51AmgeMailEstado = "";
         AssignAttri("", false, "A51AmgeMailEstado", A51AmgeMailEstado);
         Z44AmGeMailPort = 0;
         Z45AmGeMailHost = "";
         Z46AmGeMailSender = "";
         Z47AmgeMailUser = "";
         Z48AmgeMailPassword = "";
         Z49AmgeMailAuthentication = false;
         Z50AmgeMailSecure = false;
         Z51AmgeMailEstado = "";
      }

      protected void InitAll016( )
      {
         A43AmGeMailSec = "";
         InitializeNonKey016( ) ;
      }

      protected void StandaloneModalInsert016( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20224211026390", true, true);
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
         context.AddJavascriptSource("tagamge.js", "?20224211026391", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties2( )
      {
         edtAmgewsSec_Enabled = defedtAmgewsSec_Enabled;
         AssignProp("", false, edtAmgewsSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgewsSec_Enabled), 5, 0), !bGXsfl_104_Refreshing);
      }

      protected void init_level_properties3( )
      {
         edtAmgeSec2_Enabled = defedtAmgeSec2_Enabled;
         AssignProp("", false, edtAmgeSec2_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmgeSec2_Enabled), 5, 0), !bGXsfl_97_Refreshing);
      }

      protected void init_level_properties4( )
      {
         edtAmGeSec_Enabled = defedtAmGeSec_Enabled;
         AssignProp("", false, edtAmGeSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeSec_Enabled), 5, 0), !bGXsfl_91_Refreshing);
      }

      protected void init_level_properties6( )
      {
         edtAmGeMailSec_Enabled = defedtAmGeMailSec_Enabled;
         AssignProp("", false, edtAmGeMailSec_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAmGeMailSec_Enabled), 5, 0), !bGXsfl_114_Refreshing);
      }

      protected void init_default_properties( )
      {
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divTable3_Internalname = "TABLE3";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         edtAmGecod_Internalname = "AMGECOD";
         bttBtn_get_Internalname = "BTN_GET";
         divTable4_Internalname = "TABLE4";
         edtAmGedes_Internalname = "AMGEDES";
         edtAmGeval_Internalname = "AMGEVAL";
         edtAmGedet_Internalname = "AMGEDET";
         edtAmGesta_Internalname = "AMGESTA";
         edtAmGeobs_Internalname = "AMGEOBS";
         edtAmgeAnio_Internalname = "AMGEANIO";
         edtAmGeusrlog_Internalname = "AMGEUSRLOG";
         edtAmGefeclog_Internalname = "AMGEFECLOG";
         edtAmGehralog_Internalname = "AMGEHRALOG";
         edtavnRcdDeleted_4_Internalname = "vNRCDDELETED_4";
         edtAmGeSec_Internalname = "AMGESEC";
         edtAmGeMail_Internalname = "AMGEMAIL";
         divTable2_Internalname = "TABLE2";
         edtAmgeSec2_Internalname = "AMGESEC2";
         edtAmgeNoPesIni_Internalname = "AMGENOPESINI";
         edtAmgeNoPesTer_Internalname = "AMGENOPESTER";
         edtAmgeValPago_Internalname = "AMGEVALPAGO";
         edtAmgewsSec_Internalname = "AMGEWSSEC";
         edtAmgeWsPort_Internalname = "AMGEWSPORT";
         edtAmgeWsHost_Internalname = "AMGEWSHOST";
         edtAmgeWsUri_Internalname = "AMGEWSURI";
         edtAmgeWsLoc_Internalname = "AMGEWSLOC";
         edtAmgeWsTip_Internalname = "AMGEWSTIP";
         edtAmgeWsEst_Internalname = "AMGEWSEST";
         edtAmGeMailSec_Internalname = "AMGEMAILSEC";
         chkAmgeMailSecure_Internalname = "AMGEMAILSECURE";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_check_Internalname = "BTN_CHECK";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         bttBtn_help_Internalname = "BTN_HELP";
         divTable5_Internalname = "TABLE5";
         divTable1_Internalname = "TABLE1";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGrid2_Internalname = "GRID2";
         subGrid3_Internalname = "GRID3";
         subGrid4_Internalname = "GRID4";
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
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Ambiente General";
         chkAmgeMailSecure.Caption = "";
         edtAmGeMailSec_Jsonclick = "";
         subGrid4_Class = "Grid";
         subGrid4_Backcolorstyle = 0;
         edtAmGeMail_Jsonclick = "";
         edtAmGeSec_Jsonclick = "";
         edtavnRcdDeleted_4_Jsonclick = "";
         subGrid1_Class = "";
         subGrid1_Backcolorstyle = 0;
         edtAmgeValPago_Jsonclick = "";
         edtAmgeNoPesTer_Jsonclick = "";
         edtAmgeNoPesIni_Jsonclick = "";
         edtAmgeSec2_Jsonclick = "";
         subGrid2_Class = "Grid";
         subGrid2_Backcolorstyle = 0;
         edtAmgeWsEst_Jsonclick = "";
         edtAmgeWsTip_Jsonclick = "";
         edtAmgeWsLoc_Jsonclick = "";
         edtAmgeWsUri_Jsonclick = "";
         edtAmgeWsHost_Jsonclick = "";
         edtAmgeWsPort_Jsonclick = "";
         edtAmgewsSec_Jsonclick = "";
         subGrid3_Class = "Grid";
         subGrid3_Backcolorstyle = 0;
         subGrid4_Allowcollapsing = 0;
         subGrid4_Allowselection = 0;
         chkAmgeMailSecure.Enabled = 1;
         edtAmGeMailSec_Enabled = 1;
         subGrid4_Header = "";
         subGrid3_Allowcollapsing = 0;
         subGrid3_Allowselection = 0;
         edtAmgeWsEst_Enabled = 1;
         edtAmgeWsTip_Enabled = 1;
         edtAmgeWsLoc_Enabled = 1;
         edtAmgeWsUri_Enabled = 1;
         edtAmgeWsHost_Enabled = 1;
         edtAmgeWsPort_Enabled = 1;
         edtAmgewsSec_Enabled = 1;
         subGrid3_Header = "";
         subGrid2_Allowcollapsing = 0;
         subGrid2_Allowselection = 0;
         edtAmgeValPago_Enabled = 1;
         edtAmgeNoPesTer_Enabled = 1;
         edtAmgeNoPesIni_Enabled = 1;
         edtAmgeSec2_Enabled = 1;
         subGrid2_Header = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtAmGeMail_Enabled = 1;
         edtAmGeSec_Enabled = 1;
         edtavnRcdDeleted_4_Enabled = 1;
         subGrid1_Header = "";
         bttBtn_help_Visible = 1;
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_check_Enabled = 1;
         bttBtn_check_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtAmGehralog_Jsonclick = "";
         edtAmGehralog_Backcolor = (int)(0xFFFFFF);
         edtAmGehralog_Enabled = 1;
         edtAmGefeclog_Jsonclick = "";
         edtAmGefeclog_Backcolor = (int)(0xFFFFFF);
         edtAmGefeclog_Enabled = 1;
         edtAmGeusrlog_Jsonclick = "";
         edtAmGeusrlog_Backcolor = (int)(0xFFFFFF);
         edtAmGeusrlog_Enabled = 1;
         edtAmgeAnio_Jsonclick = "";
         edtAmgeAnio_Backcolor = (int)(0xFFFFFF);
         edtAmgeAnio_Enabled = 1;
         edtAmGeobs_Backcolor = (int)(0xFFFFFF);
         edtAmGeobs_Enabled = 1;
         edtAmGesta_Jsonclick = "";
         edtAmGesta_Backcolor = (int)(0xFFFFFF);
         edtAmGesta_Enabled = 1;
         edtAmGedet_Jsonclick = "";
         edtAmGedet_Backcolor = (int)(0xFFFFFF);
         edtAmGedet_Enabled = 1;
         edtAmGeval_Jsonclick = "";
         edtAmGeval_Backcolor = (int)(0xFFFFFF);
         edtAmGeval_Enabled = 1;
         edtAmGedes_Jsonclick = "";
         edtAmGedes_Backcolor = (int)(0xFFFFFF);
         edtAmGedes_Enabled = 1;
         bttBtn_get_Enabled = 1;
         bttBtn_get_Visible = 1;
         edtAmGecod_Jsonclick = "";
         edtAmGecod_Backcolor = (int)(0xFFFFFF);
         edtAmGecod_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid3_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_1042( ) ;
         while ( nGXsfl_104_idx <= nRC_GXsfl_104 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal012( ) ;
            standaloneModal012( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow012( ) ;
            nGXsfl_104_idx = (int)(nGXsfl_104_idx+1);
            sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_104_idx), 4, 0), 4, "0");
            SubsflControlProps_1042( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid3Container)) ;
         /* End function gxnrGrid3_newrow */
      }

      protected void gxnrGrid2_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_973( ) ;
         while ( nGXsfl_97_idx <= nRC_GXsfl_97 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal013( ) ;
            standaloneModal013( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow013( ) ;
            nGXsfl_97_idx = (int)(nGXsfl_97_idx+1);
            sGXsfl_97_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_97_idx), 4, 0), 4, "0");
            SubsflControlProps_973( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid2Container)) ;
         /* End function gxnrGrid2_newrow */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_914( ) ;
         while ( nGXsfl_91_idx <= nRC_GXsfl_91 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal014( ) ;
            standaloneModal014( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow014( ) ;
            nGXsfl_91_idx = (int)(nGXsfl_91_idx+1);
            sGXsfl_91_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_91_idx), 4, 0), 4, "0");
            SubsflControlProps_914( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid1Container)) ;
         /* End function gxnrGrid1_newrow */
      }

      protected void gxnrGrid4_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_1146( ) ;
         while ( nGXsfl_114_idx <= nRC_GXsfl_114 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal016( ) ;
            standaloneModal016( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow016( ) ;
            nGXsfl_114_idx = (int)(nGXsfl_114_idx+1);
            sGXsfl_114_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_114_idx), 4, 0), 4, "0");
            SubsflControlProps_1146( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid4Container)) ;
         /* End function gxnrGrid4_newrow */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "AMGEMAILSECURE_" + sGXsfl_114_idx;
         chkAmgeMailSecure.Name = GXCCtl;
         chkAmgeMailSecure.WebTags = "";
         chkAmgeMailSecure.Caption = "";
         AssignProp("", false, chkAmgeMailSecure_Internalname, "TitleCaption", chkAmgeMailSecure.Caption, !bGXsfl_114_Refreshing);
         chkAmgeMailSecure.CheckedValue = "false";
         A50AmgeMailSecure = StringUtil.StrToBool( StringUtil.BoolToStr( A50AmgeMailSecure));
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         GX_FocusControl = edtAmGedes_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      protected bool IsIns( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "INS")==0) ? true : false) ;
      }

      protected bool IsDlt( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DLT")==0) ? true : false) ;
      }

      protected bool IsUpd( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "UPD")==0) ? true : false) ;
      }

      protected bool IsDsp( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? true : false) ;
      }

      public void Valid_Amgecod( )
      {
         n10AmGePswEMail = false;
         n9AmgeStaGmail = false;
         n20AmgeAbr = false;
         n2AmgeUmedCd = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A7AmGedes", StringUtil.RTrim( A7AmGedes));
         AssignAttri("", false, "A11AmGeval", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11AmGeval), 10, 0, ".", "")));
         AssignAttri("", false, "A12AmGedet", StringUtil.RTrim( A12AmGedet));
         AssignAttri("", false, "A20AmgeAbr", StringUtil.RTrim( A20AmgeAbr));
         AssignAttri("", false, "A8AmGesta", StringUtil.RTrim( A8AmGesta));
         AssignAttri("", false, "A13AmGeobs", A13AmGeobs);
         AssignAttri("", false, "A14AmgeAnio", StringUtil.LTrim( StringUtil.NToC( (decimal)(A14AmgeAnio), 4, 0, ".", "")));
         AssignAttri("", false, "A15AmGeusrlog", StringUtil.RTrim( A15AmGeusrlog));
         AssignAttri("", false, "A16AmGefeclog", context.localUtil.Format(A16AmGefeclog, "99/99/9999"));
         AssignAttri("", false, "A17AmGehralog", StringUtil.RTrim( A17AmGehralog));
         AssignAttri("", false, "A2AmgeUmedCd", StringUtil.RTrim( A2AmgeUmedCd));
         AssignAttri("", false, "A18AmgeUmedDs", StringUtil.RTrim( A18AmgeUmedDs));
         AssignAttri("", false, "A9AmgeStaGmail", StringUtil.RTrim( A9AmgeStaGmail));
         AssignAttri("", false, "A10AmGePswEMail", StringUtil.RTrim( A10AmGePswEMail));
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z1AmGecod", StringUtil.RTrim( Z1AmGecod));
         GxWebStd.gx_hidden_field( context, "Z7AmGedes", StringUtil.RTrim( Z7AmGedes));
         GxWebStd.gx_hidden_field( context, "Z11AmGeval", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11AmGeval), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z12AmGedet", StringUtil.RTrim( Z12AmGedet));
         GxWebStd.gx_hidden_field( context, "Z20AmgeAbr", StringUtil.RTrim( Z20AmgeAbr));
         GxWebStd.gx_hidden_field( context, "Z8AmGesta", StringUtil.RTrim( Z8AmGesta));
         GxWebStd.gx_hidden_field( context, "Z13AmGeobs", Z13AmGeobs);
         GxWebStd.gx_hidden_field( context, "Z14AmgeAnio", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14AmgeAnio), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z15AmGeusrlog", StringUtil.RTrim( Z15AmGeusrlog));
         GxWebStd.gx_hidden_field( context, "Z16AmGefeclog", context.localUtil.Format(Z16AmGefeclog, "99/99/9999"));
         GxWebStd.gx_hidden_field( context, "Z17AmGehralog", StringUtil.RTrim( Z17AmGehralog));
         GxWebStd.gx_hidden_field( context, "Z2AmgeUmedCd", StringUtil.RTrim( Z2AmgeUmedCd));
         GxWebStd.gx_hidden_field( context, "Z18AmgeUmedDs", StringUtil.RTrim( Z18AmgeUmedDs));
         GxWebStd.gx_hidden_field( context, "Z9AmgeStaGmail", StringUtil.RTrim( Z9AmgeStaGmail));
         GxWebStd.gx_hidden_field( context, "Z10AmGePswEMail", StringUtil.RTrim( Z10AmGePswEMail));
         AssignProp("", false, bttBtn_get_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_get_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_check_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_check_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A20AmgeAbr',fld:'AMGEABR',pic:''},{av:'A2AmgeUmedCd',fld:'AMGEUMEDCD',pic:'99999'},{av:'A9AmgeStaGmail',fld:'AMGESTAGMAIL',pic:'!'},{av:'A10AmGePswEMail',fld:'AMGEPSWEMAIL',pic:'@!'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("VALID_AMGECOD","{handler:'Valid_Amgecod',iparms:[{av:'A10AmGePswEMail',fld:'AMGEPSWEMAIL',pic:'@!'},{av:'A9AmgeStaGmail',fld:'AMGESTAGMAIL',pic:'!'},{av:'A20AmgeAbr',fld:'AMGEABR',pic:''},{av:'A1AmGecod',fld:'AMGECOD',pic:'99999'},{av:'A2AmgeUmedCd',fld:'AMGEUMEDCD',pic:'99999'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_AMGECOD",",oparms:[{av:'A7AmGedes',fld:'AMGEDES',pic:'@!'},{av:'A11AmGeval',fld:'AMGEVAL',pic:'Z,ZZZ,ZZZ,ZZ9'},{av:'A12AmGedet',fld:'AMGEDET',pic:'@!'},{av:'A20AmgeAbr',fld:'AMGEABR',pic:''},{av:'A8AmGesta',fld:'AMGESTA',pic:''},{av:'A13AmGeobs',fld:'AMGEOBS',pic:''},{av:'A14AmgeAnio',fld:'AMGEANIO',pic:'9999'},{av:'A15AmGeusrlog',fld:'AMGEUSRLOG',pic:'99999'},{av:'A16AmGefeclog',fld:'AMGEFECLOG',pic:''},{av:'A17AmGehralog',fld:'AMGEHRALOG',pic:''},{av:'A2AmgeUmedCd',fld:'AMGEUMEDCD',pic:'99999'},{av:'A18AmgeUmedDs',fld:'AMGEUMEDDS',pic:'@!'},{av:'A9AmgeStaGmail',fld:'AMGESTAGMAIL',pic:'!'},{av:'A10AmGePswEMail',fld:'AMGEPSWEMAIL',pic:'@!'},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z1AmGecod'},{av:'Z7AmGedes'},{av:'Z11AmGeval'},{av:'Z12AmGedet'},{av:'Z20AmgeAbr'},{av:'Z8AmGesta'},{av:'Z13AmGeobs'},{av:'Z14AmgeAnio'},{av:'Z15AmGeusrlog'},{av:'Z16AmGefeclog'},{av:'Z17AmGehralog'},{av:'Z2AmgeUmedCd'},{av:'Z18AmgeUmedDs'},{av:'Z9AmgeStaGmail'},{av:'Z10AmGePswEMail'},{ctrl:'BTN_GET',prop:'Enabled'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'},{ctrl:'BTN_CHECK',prop:'Enabled'}]}");
         setEventMetadata("VALID_AMGEFECLOG","{handler:'Valid_Amgefeclog',iparms:[]");
         setEventMetadata("VALID_AMGEFECLOG",",oparms:[]}");
         setEventMetadata("VALID_AMGESEC","{handler:'Valid_Amgesec',iparms:[]");
         setEventMetadata("VALID_AMGESEC",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Amgemail',iparms:[]");
         setEventMetadata("NULL",",oparms:[]}");
         setEventMetadata("VALID_AMGESEC2","{handler:'Valid_Amgesec2',iparms:[]");
         setEventMetadata("VALID_AMGESEC2",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Amgevalpago',iparms:[]");
         setEventMetadata("NULL",",oparms:[]}");
         setEventMetadata("VALID_AMGEWSSEC","{handler:'Valid_Amgewssec',iparms:[]");
         setEventMetadata("VALID_AMGEWSSEC",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Amgewsest',iparms:[]");
         setEventMetadata("NULL",",oparms:[]}");
         setEventMetadata("VALID_AMGEMAILSEC","{handler:'Valid_Amgemailsec',iparms:[]");
         setEventMetadata("VALID_AMGEMAILSEC",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Amgemailsecure',iparms:[]");
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
         pr_default.close(1);
         pr_default.close(3);
         pr_default.close(5);
         pr_default.close(7);
         pr_default.close(9);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z1AmGecod = "";
         Z7AmGedes = "";
         Z12AmGedet = "";
         Z20AmgeAbr = "";
         Z8AmGesta = "";
         Z15AmGeusrlog = "";
         Z16AmGefeclog = DateTime.MinValue;
         Z17AmGehralog = "";
         Z9AmgeStaGmail = "";
         Z10AmGePswEMail = "";
         Z2AmgeUmedCd = "";
         Z3AmgewsSec = "";
         Z22AmgeWsHost = "";
         Z23AmgeWsUri = "";
         Z24AmgeWsLoc = "";
         Z25AmgeWsTip = "";
         Z26AmgeWsEst = "";
         Z4AmgeSec2 = "";
         Z5AmGeSec = "";
         Z30AmGeMail = "";
         Z43AmGeMailSec = "";
         Z45AmGeMailHost = "";
         Z46AmGeMailSender = "";
         Z47AmgeMailUser = "";
         Z48AmgeMailPassword = "";
         Z51AmgeMailEstado = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         Gx_mode = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         lblTextblock1_Jsonclick = "";
         A1AmGecod = "";
         bttBtn_get_Jsonclick = "";
         A7AmGedes = "";
         A12AmGedet = "";
         A8AmGesta = "";
         A13AmGeobs = "";
         A15AmGeusrlog = "";
         A16AmGefeclog = DateTime.MinValue;
         A17AmGehralog = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_check_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         bttBtn_help_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         Grid1Column = new GXWebColumn();
         A5AmGeSec = "";
         A30AmGeMail = "";
         sMode4 = "";
         sStyleString = "";
         Grid2Container = new GXWebGrid( context);
         Grid2Column = new GXWebColumn();
         A4AmgeSec2 = "";
         sMode3 = "";
         Grid3Container = new GXWebGrid( context);
         Grid3Column = new GXWebColumn();
         A3AmgewsSec = "";
         A22AmgeWsHost = "";
         A23AmgeWsUri = "";
         A24AmgeWsLoc = "";
         A25AmgeWsTip = "";
         A26AmgeWsEst = "";
         sMode2 = "";
         Grid4Container = new GXWebGrid( context);
         Grid4Column = new GXWebColumn();
         A43AmGeMailSec = "";
         sMode6 = "";
         A20AmgeAbr = "";
         A9AmgeStaGmail = "";
         A10AmGePswEMail = "";
         A2AmgeUmedCd = "";
         A18AmgeUmedDs = "";
         A45AmGeMailHost = "";
         A46AmGeMailSender = "";
         A47AmgeMailUser = "";
         A48AmgeMailPassword = "";
         A51AmgeMailEstado = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         endTrnMsgTxt = "";
         endTrnMsgCod = "";
         sMode1 = "";
         GXCCtl = "";
         Z13AmGeobs = "";
         Z18AmgeUmedDs = "";
         T000112_A18AmgeUmedDs = new String[] {""} ;
         T000113_A1AmGecod = new String[] {""} ;
         T000113_A7AmGedes = new String[] {""} ;
         T000113_n7AmGedes = new bool[] {false} ;
         T000113_A11AmGeval = new long[1] ;
         T000113_n11AmGeval = new bool[] {false} ;
         T000113_A12AmGedet = new String[] {""} ;
         T000113_n12AmGedet = new bool[] {false} ;
         T000113_A20AmgeAbr = new String[] {""} ;
         T000113_n20AmgeAbr = new bool[] {false} ;
         T000113_A8AmGesta = new String[] {""} ;
         T000113_n8AmGesta = new bool[] {false} ;
         T000113_A13AmGeobs = new String[] {""} ;
         T000113_n13AmGeobs = new bool[] {false} ;
         T000113_A14AmgeAnio = new short[1] ;
         T000113_n14AmgeAnio = new bool[] {false} ;
         T000113_A15AmGeusrlog = new String[] {""} ;
         T000113_n15AmGeusrlog = new bool[] {false} ;
         T000113_A16AmGefeclog = new DateTime[] {DateTime.MinValue} ;
         T000113_n16AmGefeclog = new bool[] {false} ;
         T000113_A17AmGehralog = new String[] {""} ;
         T000113_n17AmGehralog = new bool[] {false} ;
         T000113_A18AmgeUmedDs = new String[] {""} ;
         T000113_A9AmgeStaGmail = new String[] {""} ;
         T000113_n9AmgeStaGmail = new bool[] {false} ;
         T000113_A10AmGePswEMail = new String[] {""} ;
         T000113_n10AmGePswEMail = new bool[] {false} ;
         T000113_A2AmgeUmedCd = new String[] {""} ;
         T000113_n2AmgeUmedCd = new bool[] {false} ;
         T000114_A1AmGecod = new String[] {""} ;
         T000111_A1AmGecod = new String[] {""} ;
         T000111_A7AmGedes = new String[] {""} ;
         T000111_n7AmGedes = new bool[] {false} ;
         T000111_A11AmGeval = new long[1] ;
         T000111_n11AmGeval = new bool[] {false} ;
         T000111_A12AmGedet = new String[] {""} ;
         T000111_n12AmGedet = new bool[] {false} ;
         T000111_A20AmgeAbr = new String[] {""} ;
         T000111_n20AmgeAbr = new bool[] {false} ;
         T000111_A8AmGesta = new String[] {""} ;
         T000111_n8AmGesta = new bool[] {false} ;
         T000111_A13AmGeobs = new String[] {""} ;
         T000111_n13AmGeobs = new bool[] {false} ;
         T000111_A14AmgeAnio = new short[1] ;
         T000111_n14AmgeAnio = new bool[] {false} ;
         T000111_A15AmGeusrlog = new String[] {""} ;
         T000111_n15AmGeusrlog = new bool[] {false} ;
         T000111_A16AmGefeclog = new DateTime[] {DateTime.MinValue} ;
         T000111_n16AmGefeclog = new bool[] {false} ;
         T000111_A17AmGehralog = new String[] {""} ;
         T000111_n17AmGehralog = new bool[] {false} ;
         T000111_A9AmgeStaGmail = new String[] {""} ;
         T000111_n9AmgeStaGmail = new bool[] {false} ;
         T000111_A10AmGePswEMail = new String[] {""} ;
         T000111_n10AmGePswEMail = new bool[] {false} ;
         T000111_A2AmgeUmedCd = new String[] {""} ;
         T000111_n2AmgeUmedCd = new bool[] {false} ;
         T000115_A1AmGecod = new String[] {""} ;
         T000116_A1AmGecod = new String[] {""} ;
         T000110_A1AmGecod = new String[] {""} ;
         T000110_A7AmGedes = new String[] {""} ;
         T000110_n7AmGedes = new bool[] {false} ;
         T000110_A11AmGeval = new long[1] ;
         T000110_n11AmGeval = new bool[] {false} ;
         T000110_A12AmGedet = new String[] {""} ;
         T000110_n12AmGedet = new bool[] {false} ;
         T000110_A20AmgeAbr = new String[] {""} ;
         T000110_n20AmgeAbr = new bool[] {false} ;
         T000110_A8AmGesta = new String[] {""} ;
         T000110_n8AmGesta = new bool[] {false} ;
         T000110_A13AmGeobs = new String[] {""} ;
         T000110_n13AmGeobs = new bool[] {false} ;
         T000110_A14AmgeAnio = new short[1] ;
         T000110_n14AmgeAnio = new bool[] {false} ;
         T000110_A15AmGeusrlog = new String[] {""} ;
         T000110_n15AmGeusrlog = new bool[] {false} ;
         T000110_A16AmGefeclog = new DateTime[] {DateTime.MinValue} ;
         T000110_n16AmGefeclog = new bool[] {false} ;
         T000110_A17AmGehralog = new String[] {""} ;
         T000110_n17AmGehralog = new bool[] {false} ;
         T000110_A9AmgeStaGmail = new String[] {""} ;
         T000110_n9AmgeStaGmail = new bool[] {false} ;
         T000110_A10AmGePswEMail = new String[] {""} ;
         T000110_n10AmGePswEMail = new bool[] {false} ;
         T000110_A2AmgeUmedCd = new String[] {""} ;
         T000110_n2AmgeUmedCd = new bool[] {false} ;
         T000120_A1AmGecod = new String[] {""} ;
         T000121_A1AmGecod = new String[] {""} ;
         T000121_A3AmgewsSec = new String[] {""} ;
         T000121_A21AmgeWsPort = new short[1] ;
         T000121_A22AmgeWsHost = new String[] {""} ;
         T000121_A23AmgeWsUri = new String[] {""} ;
         T000121_A24AmgeWsLoc = new String[] {""} ;
         T000121_A25AmgeWsTip = new String[] {""} ;
         T000121_A26AmgeWsEst = new String[] {""} ;
         T000122_A1AmGecod = new String[] {""} ;
         T000122_A3AmgewsSec = new String[] {""} ;
         T00019_A1AmGecod = new String[] {""} ;
         T00019_A3AmgewsSec = new String[] {""} ;
         T00019_A21AmgeWsPort = new short[1] ;
         T00019_A22AmgeWsHost = new String[] {""} ;
         T00019_A23AmgeWsUri = new String[] {""} ;
         T00019_A24AmgeWsLoc = new String[] {""} ;
         T00019_A25AmgeWsTip = new String[] {""} ;
         T00019_A26AmgeWsEst = new String[] {""} ;
         T00018_A1AmGecod = new String[] {""} ;
         T00018_A3AmgewsSec = new String[] {""} ;
         T00018_A21AmgeWsPort = new short[1] ;
         T00018_A22AmgeWsHost = new String[] {""} ;
         T00018_A23AmgeWsUri = new String[] {""} ;
         T00018_A24AmgeWsLoc = new String[] {""} ;
         T00018_A25AmgeWsTip = new String[] {""} ;
         T00018_A26AmgeWsEst = new String[] {""} ;
         T000126_A1AmGecod = new String[] {""} ;
         T000126_A3AmgewsSec = new String[] {""} ;
         T000127_A1AmGecod = new String[] {""} ;
         T000127_A4AmgeSec2 = new String[] {""} ;
         T000127_A27AmgeNoPesIni = new short[1] ;
         T000127_n27AmgeNoPesIni = new bool[] {false} ;
         T000127_A28AmgeNoPesTer = new short[1] ;
         T000127_n28AmgeNoPesTer = new bool[] {false} ;
         T000127_A29AmgeValPago = new decimal[1] ;
         T000127_n29AmgeValPago = new bool[] {false} ;
         T000128_A1AmGecod = new String[] {""} ;
         T000128_A4AmgeSec2 = new String[] {""} ;
         T00017_A1AmGecod = new String[] {""} ;
         T00017_A4AmgeSec2 = new String[] {""} ;
         T00017_A27AmgeNoPesIni = new short[1] ;
         T00017_n27AmgeNoPesIni = new bool[] {false} ;
         T00017_A28AmgeNoPesTer = new short[1] ;
         T00017_n28AmgeNoPesTer = new bool[] {false} ;
         T00017_A29AmgeValPago = new decimal[1] ;
         T00017_n29AmgeValPago = new bool[] {false} ;
         T00016_A1AmGecod = new String[] {""} ;
         T00016_A4AmgeSec2 = new String[] {""} ;
         T00016_A27AmgeNoPesIni = new short[1] ;
         T00016_n27AmgeNoPesIni = new bool[] {false} ;
         T00016_A28AmgeNoPesTer = new short[1] ;
         T00016_n28AmgeNoPesTer = new bool[] {false} ;
         T00016_A29AmgeValPago = new decimal[1] ;
         T00016_n29AmgeValPago = new bool[] {false} ;
         T000132_A1AmGecod = new String[] {""} ;
         T000132_A4AmgeSec2 = new String[] {""} ;
         T000133_A1AmGecod = new String[] {""} ;
         T000133_A5AmGeSec = new String[] {""} ;
         T000133_A30AmGeMail = new String[] {""} ;
         T000133_n30AmGeMail = new bool[] {false} ;
         T000134_A1AmGecod = new String[] {""} ;
         T000134_A5AmGeSec = new String[] {""} ;
         T00015_A1AmGecod = new String[] {""} ;
         T00015_A5AmGeSec = new String[] {""} ;
         T00015_A30AmGeMail = new String[] {""} ;
         T00015_n30AmGeMail = new bool[] {false} ;
         T00014_A1AmGecod = new String[] {""} ;
         T00014_A5AmGeSec = new String[] {""} ;
         T00014_A30AmGeMail = new String[] {""} ;
         T00014_n30AmGeMail = new bool[] {false} ;
         T000138_A1AmGecod = new String[] {""} ;
         T000138_A5AmGeSec = new String[] {""} ;
         T000139_A1AmGecod = new String[] {""} ;
         T000139_A43AmGeMailSec = new String[] {""} ;
         T000139_A44AmGeMailPort = new short[1] ;
         T000139_A45AmGeMailHost = new String[] {""} ;
         T000139_A46AmGeMailSender = new String[] {""} ;
         T000139_A47AmgeMailUser = new String[] {""} ;
         T000139_A48AmgeMailPassword = new String[] {""} ;
         T000139_A49AmgeMailAuthentication = new bool[] {false} ;
         T000139_A50AmgeMailSecure = new bool[] {false} ;
         T000139_A51AmgeMailEstado = new String[] {""} ;
         T000140_A1AmGecod = new String[] {""} ;
         T000140_A43AmGeMailSec = new String[] {""} ;
         T00013_A1AmGecod = new String[] {""} ;
         T00013_A43AmGeMailSec = new String[] {""} ;
         T00013_A44AmGeMailPort = new short[1] ;
         T00013_A45AmGeMailHost = new String[] {""} ;
         T00013_A46AmGeMailSender = new String[] {""} ;
         T00013_A47AmgeMailUser = new String[] {""} ;
         T00013_A48AmgeMailPassword = new String[] {""} ;
         T00013_A49AmgeMailAuthentication = new bool[] {false} ;
         T00013_A50AmgeMailSecure = new bool[] {false} ;
         T00013_A51AmgeMailEstado = new String[] {""} ;
         T00012_A1AmGecod = new String[] {""} ;
         T00012_A43AmGeMailSec = new String[] {""} ;
         T00012_A44AmGeMailPort = new short[1] ;
         T00012_A45AmGeMailHost = new String[] {""} ;
         T00012_A46AmGeMailSender = new String[] {""} ;
         T00012_A47AmgeMailUser = new String[] {""} ;
         T00012_A48AmgeMailPassword = new String[] {""} ;
         T00012_A49AmgeMailAuthentication = new bool[] {false} ;
         T00012_A50AmgeMailSecure = new bool[] {false} ;
         T00012_A51AmgeMailEstado = new String[] {""} ;
         T000144_A1AmGecod = new String[] {""} ;
         T000144_A43AmGeMailSec = new String[] {""} ;
         Grid3Row = new GXWebRow();
         subGrid3_Linesclass = "";
         ROClassString = "";
         Grid2Row = new GXWebRow();
         subGrid2_Linesclass = "";
         Grid1Row = new GXWebRow();
         subGrid1_Linesclass = "";
         Grid4Row = new GXWebRow();
         subGrid4_Linesclass = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         ZZ1AmGecod = "";
         ZZ7AmGedes = "";
         ZZ12AmGedet = "";
         ZZ20AmgeAbr = "";
         ZZ8AmGesta = "";
         ZZ13AmGeobs = "";
         ZZ15AmGeusrlog = "";
         ZZ16AmGefeclog = DateTime.MinValue;
         ZZ17AmGehralog = "";
         ZZ2AmgeUmedCd = "";
         ZZ18AmgeUmedDs = "";
         ZZ9AmgeStaGmail = "";
         ZZ10AmGePswEMail = "";
         pr_sistema = new DataStoreProvider(context, new GeneXus.Programs.tagamge__sistema(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tagamge__default(),
            new Object[][] {
                new Object[] {
               T00012_A1AmGecod, T00012_A43AmGeMailSec, T00012_A44AmGeMailPort, T00012_A45AmGeMailHost, T00012_A46AmGeMailSender, T00012_A47AmgeMailUser, T00012_A48AmgeMailPassword, T00012_A49AmgeMailAuthentication, T00012_A50AmgeMailSecure, T00012_A51AmgeMailEstado
               }
               , new Object[] {
               T00013_A1AmGecod, T00013_A43AmGeMailSec, T00013_A44AmGeMailPort, T00013_A45AmGeMailHost, T00013_A46AmGeMailSender, T00013_A47AmgeMailUser, T00013_A48AmgeMailPassword, T00013_A49AmgeMailAuthentication, T00013_A50AmgeMailSecure, T00013_A51AmgeMailEstado
               }
               , new Object[] {
               T00014_A1AmGecod, T00014_A5AmGeSec, T00014_A30AmGeMail, T00014_n30AmGeMail
               }
               , new Object[] {
               T00015_A1AmGecod, T00015_A5AmGeSec, T00015_A30AmGeMail, T00015_n30AmGeMail
               }
               , new Object[] {
               T00016_A1AmGecod, T00016_A4AmgeSec2, T00016_A27AmgeNoPesIni, T00016_n27AmgeNoPesIni, T00016_A28AmgeNoPesTer, T00016_n28AmgeNoPesTer, T00016_A29AmgeValPago, T00016_n29AmgeValPago
               }
               , new Object[] {
               T00017_A1AmGecod, T00017_A4AmgeSec2, T00017_A27AmgeNoPesIni, T00017_n27AmgeNoPesIni, T00017_A28AmgeNoPesTer, T00017_n28AmgeNoPesTer, T00017_A29AmgeValPago, T00017_n29AmgeValPago
               }
               , new Object[] {
               T00018_A1AmGecod, T00018_A3AmgewsSec, T00018_A21AmgeWsPort, T00018_A22AmgeWsHost, T00018_A23AmgeWsUri, T00018_A24AmgeWsLoc, T00018_A25AmgeWsTip, T00018_A26AmgeWsEst
               }
               , new Object[] {
               T00019_A1AmGecod, T00019_A3AmgewsSec, T00019_A21AmgeWsPort, T00019_A22AmgeWsHost, T00019_A23AmgeWsUri, T00019_A24AmgeWsLoc, T00019_A25AmgeWsTip, T00019_A26AmgeWsEst
               }
               , new Object[] {
               T000110_A1AmGecod, T000110_A7AmGedes, T000110_n7AmGedes, T000110_A11AmGeval, T000110_n11AmGeval, T000110_A12AmGedet, T000110_n12AmGedet, T000110_A20AmgeAbr, T000110_n20AmgeAbr, T000110_A8AmGesta,
               T000110_n8AmGesta, T000110_A13AmGeobs, T000110_n13AmGeobs, T000110_A14AmgeAnio, T000110_n14AmgeAnio, T000110_A15AmGeusrlog, T000110_n15AmGeusrlog, T000110_A16AmGefeclog, T000110_n16AmGefeclog, T000110_A17AmGehralog,
               T000110_n17AmGehralog, T000110_A9AmgeStaGmail, T000110_n9AmgeStaGmail, T000110_A10AmGePswEMail, T000110_n10AmGePswEMail, T000110_A2AmgeUmedCd, T000110_n2AmgeUmedCd
               }
               , new Object[] {
               T000111_A1AmGecod, T000111_A7AmGedes, T000111_n7AmGedes, T000111_A11AmGeval, T000111_n11AmGeval, T000111_A12AmGedet, T000111_n12AmGedet, T000111_A20AmgeAbr, T000111_n20AmgeAbr, T000111_A8AmGesta,
               T000111_n8AmGesta, T000111_A13AmGeobs, T000111_n13AmGeobs, T000111_A14AmgeAnio, T000111_n14AmgeAnio, T000111_A15AmGeusrlog, T000111_n15AmGeusrlog, T000111_A16AmGefeclog, T000111_n16AmGefeclog, T000111_A17AmGehralog,
               T000111_n17AmGehralog, T000111_A9AmgeStaGmail, T000111_n9AmgeStaGmail, T000111_A10AmGePswEMail, T000111_n10AmGePswEMail, T000111_A2AmgeUmedCd, T000111_n2AmgeUmedCd
               }
               , new Object[] {
               T000112_A18AmgeUmedDs
               }
               , new Object[] {
               T000113_A1AmGecod, T000113_A7AmGedes, T000113_n7AmGedes, T000113_A11AmGeval, T000113_n11AmGeval, T000113_A12AmGedet, T000113_n12AmGedet, T000113_A20AmgeAbr, T000113_n20AmgeAbr, T000113_A8AmGesta,
               T000113_n8AmGesta, T000113_A13AmGeobs, T000113_n13AmGeobs, T000113_A14AmgeAnio, T000113_n14AmgeAnio, T000113_A15AmGeusrlog, T000113_n15AmGeusrlog, T000113_A16AmGefeclog, T000113_n16AmGefeclog, T000113_A17AmGehralog,
               T000113_n17AmGehralog, T000113_A18AmgeUmedDs, T000113_A9AmgeStaGmail, T000113_n9AmgeStaGmail, T000113_A10AmGePswEMail, T000113_n10AmGePswEMail, T000113_A2AmgeUmedCd, T000113_n2AmgeUmedCd
               }
               , new Object[] {
               T000114_A1AmGecod
               }
               , new Object[] {
               T000115_A1AmGecod
               }
               , new Object[] {
               T000116_A1AmGecod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000120_A1AmGecod
               }
               , new Object[] {
               T000121_A1AmGecod, T000121_A3AmgewsSec, T000121_A21AmgeWsPort, T000121_A22AmgeWsHost, T000121_A23AmgeWsUri, T000121_A24AmgeWsLoc, T000121_A25AmgeWsTip, T000121_A26AmgeWsEst
               }
               , new Object[] {
               T000122_A1AmGecod, T000122_A3AmgewsSec
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000126_A1AmGecod, T000126_A3AmgewsSec
               }
               , new Object[] {
               T000127_A1AmGecod, T000127_A4AmgeSec2, T000127_A27AmgeNoPesIni, T000127_n27AmgeNoPesIni, T000127_A28AmgeNoPesTer, T000127_n28AmgeNoPesTer, T000127_A29AmgeValPago, T000127_n29AmgeValPago
               }
               , new Object[] {
               T000128_A1AmGecod, T000128_A4AmgeSec2
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000132_A1AmGecod, T000132_A4AmgeSec2
               }
               , new Object[] {
               T000133_A1AmGecod, T000133_A5AmGeSec, T000133_A30AmGeMail, T000133_n30AmGeMail
               }
               , new Object[] {
               T000134_A1AmGecod, T000134_A5AmGeSec
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000138_A1AmGecod, T000138_A5AmGeSec
               }
               , new Object[] {
               T000139_A1AmGecod, T000139_A43AmGeMailSec, T000139_A44AmGeMailPort, T000139_A45AmGeMailHost, T000139_A46AmGeMailSender, T000139_A47AmgeMailUser, T000139_A48AmgeMailPassword, T000139_A49AmgeMailAuthentication, T000139_A50AmgeMailSecure, T000139_A51AmgeMailEstado
               }
               , new Object[] {
               T000140_A1AmGecod, T000140_A43AmGeMailSec
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000144_A1AmGecod, T000144_A43AmGeMailSec
               }
            }
         );
      }

      private short Z14AmgeAnio ;
      private short Z21AmgeWsPort ;
      private short nRcdDeleted_2 ;
      private short nRcdExists_2 ;
      private short nIsMod_2 ;
      private short Z27AmgeNoPesIni ;
      private short Z28AmgeNoPesTer ;
      private short nRcdDeleted_3 ;
      private short nRcdExists_3 ;
      private short nIsMod_3 ;
      private short nRcdDeleted_4 ;
      private short nRcdExists_4 ;
      private short nIsMod_4 ;
      private short Z44AmGeMailPort ;
      private short nRcdDeleted_6 ;
      private short nRcdExists_6 ;
      private short nIsMod_6 ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A14AmgeAnio ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nBlankRcdCount4 ;
      private short RcdFound4 ;
      private short nBlankRcdUsr4 ;
      private short subGrid2_Backcolorstyle ;
      private short A27AmgeNoPesIni ;
      private short A28AmgeNoPesTer ;
      private short subGrid2_Allowselection ;
      private short subGrid2_Allowhovering ;
      private short subGrid2_Allowcollapsing ;
      private short subGrid2_Collapsed ;
      private short nBlankRcdCount3 ;
      private short RcdFound3 ;
      private short nBlankRcdUsr3 ;
      private short subGrid3_Backcolorstyle ;
      private short A21AmgeWsPort ;
      private short subGrid3_Allowselection ;
      private short subGrid3_Allowhovering ;
      private short subGrid3_Allowcollapsing ;
      private short subGrid3_Collapsed ;
      private short nBlankRcdCount2 ;
      private short RcdFound2 ;
      private short nBlankRcdUsr2 ;
      private short subGrid4_Backcolorstyle ;
      private short subGrid4_Allowselection ;
      private short subGrid4_Allowhovering ;
      private short subGrid4_Allowcollapsing ;
      private short subGrid4_Collapsed ;
      private short nBlankRcdCount6 ;
      private short RcdFound6 ;
      private short nBlankRcdUsr6 ;
      private short A44AmGeMailPort ;
      private short GX_JID ;
      private short RcdFound1 ;
      private short nIsDirty_1 ;
      private short Gx_BScreen ;
      private short nIsDirty_2 ;
      private short nIsDirty_3 ;
      private short nIsDirty_4 ;
      private short nIsDirty_6 ;
      private short subGrid3_Backstyle ;
      private short subGrid2_Backstyle ;
      private short subGrid1_Backstyle ;
      private short subGrid4_Backstyle ;
      private short gxajaxcallmode ;
      private short ZZ14AmgeAnio ;
      private int nRC_GXsfl_104 ;
      private int nGXsfl_104_idx=1 ;
      private int nRC_GXsfl_97 ;
      private int nGXsfl_97_idx=1 ;
      private int nRC_GXsfl_91 ;
      private int nGXsfl_91_idx=1 ;
      private int nRC_GXsfl_114 ;
      private int nGXsfl_114_idx=1 ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtAmGecod_Enabled ;
      private int bttBtn_get_Visible ;
      private int bttBtn_get_Enabled ;
      private int edtAmGedes_Enabled ;
      private int edtAmGeval_Enabled ;
      private int edtAmGedet_Enabled ;
      private int edtAmGesta_Enabled ;
      private int edtAmGeobs_Enabled ;
      private int edtAmgeAnio_Enabled ;
      private int edtAmGeusrlog_Enabled ;
      private int edtAmGefeclog_Enabled ;
      private int edtAmGehralog_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_check_Visible ;
      private int bttBtn_check_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int bttBtn_help_Visible ;
      private int edtavnRcdDeleted_4_Enabled ;
      private int edtAmGeSec_Enabled ;
      private int edtAmGeMail_Enabled ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int fRowAdded ;
      private int edtAmgeSec2_Enabled ;
      private int edtAmgeNoPesIni_Enabled ;
      private int edtAmgeNoPesTer_Enabled ;
      private int edtAmgeValPago_Enabled ;
      private int subGrid2_Selectedindex ;
      private int subGrid2_Selectioncolor ;
      private int subGrid2_Hoveringcolor ;
      private int edtAmgewsSec_Enabled ;
      private int edtAmgeWsPort_Enabled ;
      private int edtAmgeWsHost_Enabled ;
      private int edtAmgeWsUri_Enabled ;
      private int edtAmgeWsLoc_Enabled ;
      private int edtAmgeWsTip_Enabled ;
      private int edtAmgeWsEst_Enabled ;
      private int subGrid3_Selectedindex ;
      private int subGrid3_Selectioncolor ;
      private int subGrid3_Hoveringcolor ;
      private int edtAmGeMailSec_Enabled ;
      private int subGrid4_Selectedindex ;
      private int subGrid4_Selectioncolor ;
      private int subGrid4_Hoveringcolor ;
      private int subGrid3_Backcolor ;
      private int subGrid3_Allbackcolor ;
      private int subGrid2_Backcolor ;
      private int subGrid2_Allbackcolor ;
      private int subGrid1_Backcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid4_Backcolor ;
      private int subGrid4_Allbackcolor ;
      private int defedtAmGeMailSec_Enabled ;
      private int defedtAmgewsSec_Enabled ;
      private int defedtAmgeSec2_Enabled ;
      private int defedtAmGeSec_Enabled ;
      private int idxLst ;
      private int edtAmGehralog_Backcolor ;
      private int edtAmGefeclog_Backcolor ;
      private int edtAmGeusrlog_Backcolor ;
      private int edtAmgeAnio_Backcolor ;
      private int edtAmGeobs_Backcolor ;
      private int edtAmGesta_Backcolor ;
      private int edtAmGedet_Backcolor ;
      private int edtAmGeval_Backcolor ;
      private int edtAmGedes_Backcolor ;
      private int edtAmGecod_Backcolor ;
      private long Z11AmGeval ;
      private long A11AmGeval ;
      private long GRID3_nFirstRecordOnPage ;
      private long GRID2_nFirstRecordOnPage ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID4_nFirstRecordOnPage ;
      private long ZZ11AmGeval ;
      private decimal Z29AmgeValPago ;
      private decimal A29AmgeValPago ;
      private String sPrefix ;
      private String Z1AmGecod ;
      private String Z7AmGedes ;
      private String Z12AmGedet ;
      private String Z20AmgeAbr ;
      private String Z8AmGesta ;
      private String Z15AmGeusrlog ;
      private String Z17AmGehralog ;
      private String Z9AmgeStaGmail ;
      private String Z10AmGePswEMail ;
      private String Z2AmgeUmedCd ;
      private String Z3AmgewsSec ;
      private String Z22AmgeWsHost ;
      private String Z24AmgeWsLoc ;
      private String Z25AmgeWsTip ;
      private String Z26AmgeWsEst ;
      private String Z4AmgeSec2 ;
      private String Z5AmGeSec ;
      private String Z30AmGeMail ;
      private String Z43AmGeMailSec ;
      private String Z51AmgeMailEstado ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_97_idx="0001" ;
      private String Gx_mode ;
      private String sGXsfl_104_idx="0001" ;
      private String sGXsfl_114_idx="0001" ;
      private String sGXsfl_91_idx="0001" ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtAmGecod_Internalname ;
      private String divMaintable_Internalname ;
      private String divTable1_Internalname ;
      private String divTable3_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String divTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String divTable4_Internalname ;
      private String A1AmGecod ;
      private String edtAmGecod_Jsonclick ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String edtAmGedes_Internalname ;
      private String A7AmGedes ;
      private String edtAmGedes_Jsonclick ;
      private String edtAmGeval_Internalname ;
      private String edtAmGeval_Jsonclick ;
      private String edtAmGedet_Internalname ;
      private String A12AmGedet ;
      private String edtAmGedet_Jsonclick ;
      private String edtAmGesta_Internalname ;
      private String A8AmGesta ;
      private String edtAmGesta_Jsonclick ;
      private String edtAmGeobs_Internalname ;
      private String edtAmgeAnio_Internalname ;
      private String edtAmgeAnio_Jsonclick ;
      private String edtAmGeusrlog_Internalname ;
      private String A15AmGeusrlog ;
      private String edtAmGeusrlog_Jsonclick ;
      private String edtAmGefeclog_Internalname ;
      private String edtAmGefeclog_Jsonclick ;
      private String edtAmGehralog_Internalname ;
      private String A17AmGehralog ;
      private String edtAmGehralog_Jsonclick ;
      private String divTable5_Internalname ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_check_Internalname ;
      private String bttBtn_check_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String bttBtn_help_Internalname ;
      private String bttBtn_help_Jsonclick ;
      private String subGrid1_Header ;
      private String A5AmGeSec ;
      private String A30AmGeMail ;
      private String sMode4 ;
      private String edtavnRcdDeleted_4_Internalname ;
      private String edtAmGeSec_Internalname ;
      private String edtAmGeMail_Internalname ;
      private String sStyleString ;
      private String subGrid2_Header ;
      private String A4AmgeSec2 ;
      private String sMode3 ;
      private String edtAmgeSec2_Internalname ;
      private String edtAmgeNoPesIni_Internalname ;
      private String edtAmgeNoPesTer_Internalname ;
      private String edtAmgeValPago_Internalname ;
      private String subGrid3_Header ;
      private String A3AmgewsSec ;
      private String A22AmgeWsHost ;
      private String A24AmgeWsLoc ;
      private String A25AmgeWsTip ;
      private String A26AmgeWsEst ;
      private String sMode2 ;
      private String edtAmgewsSec_Internalname ;
      private String edtAmgeWsPort_Internalname ;
      private String edtAmgeWsHost_Internalname ;
      private String edtAmgeWsUri_Internalname ;
      private String edtAmgeWsLoc_Internalname ;
      private String edtAmgeWsTip_Internalname ;
      private String edtAmgeWsEst_Internalname ;
      private String subGrid4_Header ;
      private String A43AmGeMailSec ;
      private String sMode6 ;
      private String edtAmGeMailSec_Internalname ;
      private String chkAmgeMailSecure_Internalname ;
      private String A20AmgeAbr ;
      private String A9AmgeStaGmail ;
      private String A10AmGePswEMail ;
      private String A2AmgeUmedCd ;
      private String A18AmgeUmedDs ;
      private String A51AmgeMailEstado ;
      private String hsh ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String endTrnMsgTxt ;
      private String endTrnMsgCod ;
      private String sMode1 ;
      private String GXCCtl ;
      private String Z18AmgeUmedDs ;
      private String sGXsfl_104_fel_idx="0001" ;
      private String subGrid3_Class ;
      private String subGrid3_Linesclass ;
      private String ROClassString ;
      private String edtAmgewsSec_Jsonclick ;
      private String edtAmgeWsPort_Jsonclick ;
      private String edtAmgeWsHost_Jsonclick ;
      private String edtAmgeWsUri_Jsonclick ;
      private String edtAmgeWsLoc_Jsonclick ;
      private String edtAmgeWsTip_Jsonclick ;
      private String edtAmgeWsEst_Jsonclick ;
      private String sGXsfl_97_fel_idx="0001" ;
      private String subGrid2_Class ;
      private String subGrid2_Linesclass ;
      private String edtAmgeSec2_Jsonclick ;
      private String edtAmgeNoPesIni_Jsonclick ;
      private String edtAmgeNoPesTer_Jsonclick ;
      private String edtAmgeValPago_Jsonclick ;
      private String sGXsfl_91_fel_idx="0001" ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String edtavnRcdDeleted_4_Jsonclick ;
      private String edtAmGeSec_Jsonclick ;
      private String edtAmGeMail_Jsonclick ;
      private String sGXsfl_114_fel_idx="0001" ;
      private String subGrid4_Class ;
      private String subGrid4_Linesclass ;
      private String edtAmGeMailSec_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGrid2_Internalname ;
      private String subGrid3_Internalname ;
      private String subGrid4_Internalname ;
      private String subGrid1_Internalname ;
      private String ZZ1AmGecod ;
      private String ZZ7AmGedes ;
      private String ZZ12AmGedet ;
      private String ZZ20AmgeAbr ;
      private String ZZ8AmGesta ;
      private String ZZ15AmGeusrlog ;
      private String ZZ17AmGehralog ;
      private String ZZ2AmgeUmedCd ;
      private String ZZ18AmgeUmedDs ;
      private String ZZ9AmgeStaGmail ;
      private String ZZ10AmGePswEMail ;
      private DateTime Z16AmGefeclog ;
      private DateTime A16AmGefeclog ;
      private DateTime ZZ16AmGefeclog ;
      private bool Z49AmgeMailAuthentication ;
      private bool Z50AmgeMailSecure ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_91_Refreshing=false ;
      private bool bGXsfl_97_Refreshing=false ;
      private bool bGXsfl_104_Refreshing=false ;
      private bool A50AmgeMailSecure ;
      private bool bGXsfl_114_Refreshing=false ;
      private bool n7AmGedes ;
      private bool n11AmGeval ;
      private bool n12AmGedet ;
      private bool n20AmgeAbr ;
      private bool n8AmGesta ;
      private bool n14AmgeAnio ;
      private bool n15AmGeusrlog ;
      private bool n16AmGefeclog ;
      private bool n17AmGehralog ;
      private bool n9AmgeStaGmail ;
      private bool n10AmGePswEMail ;
      private bool n2AmgeUmedCd ;
      private bool A49AmgeMailAuthentication ;
      private bool n13AmGeobs ;
      private bool Gx_longc ;
      private bool n27AmgeNoPesIni ;
      private bool n28AmgeNoPesTer ;
      private bool n29AmgeValPago ;
      private bool n30AmGeMail ;
      private String A13AmGeobs ;
      private String Z13AmGeobs ;
      private String ZZ13AmGeobs ;
      private String Z23AmgeWsUri ;
      private String Z45AmGeMailHost ;
      private String Z46AmGeMailSender ;
      private String Z47AmgeMailUser ;
      private String Z48AmgeMailPassword ;
      private String A23AmgeWsUri ;
      private String A45AmGeMailHost ;
      private String A46AmGeMailSender ;
      private String A47AmgeMailUser ;
      private String A48AmgeMailPassword ;
      private GXProperties forbiddenHiddens ;
      private GXWebGrid Grid1Container ;
      private GXWebGrid Grid2Container ;
      private GXWebGrid Grid3Container ;
      private GXWebGrid Grid4Container ;
      private GXWebRow Grid3Row ;
      private GXWebRow Grid2Row ;
      private GXWebRow Grid1Row ;
      private GXWebRow Grid4Row ;
      private GXWebColumn Grid1Column ;
      private GXWebColumn Grid2Column ;
      private GXWebColumn Grid3Column ;
      private GXWebColumn Grid4Column ;
      private IGxDataStore dsSistema ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkAmgeMailSecure ;
      private IDataStoreProvider pr_default ;
      private String[] T000112_A18AmgeUmedDs ;
      private String[] T000113_A1AmGecod ;
      private String[] T000113_A7AmGedes ;
      private bool[] T000113_n7AmGedes ;
      private long[] T000113_A11AmGeval ;
      private bool[] T000113_n11AmGeval ;
      private String[] T000113_A12AmGedet ;
      private bool[] T000113_n12AmGedet ;
      private String[] T000113_A20AmgeAbr ;
      private bool[] T000113_n20AmgeAbr ;
      private String[] T000113_A8AmGesta ;
      private bool[] T000113_n8AmGesta ;
      private String[] T000113_A13AmGeobs ;
      private bool[] T000113_n13AmGeobs ;
      private short[] T000113_A14AmgeAnio ;
      private bool[] T000113_n14AmgeAnio ;
      private String[] T000113_A15AmGeusrlog ;
      private bool[] T000113_n15AmGeusrlog ;
      private DateTime[] T000113_A16AmGefeclog ;
      private bool[] T000113_n16AmGefeclog ;
      private String[] T000113_A17AmGehralog ;
      private bool[] T000113_n17AmGehralog ;
      private String[] T000113_A18AmgeUmedDs ;
      private String[] T000113_A9AmgeStaGmail ;
      private bool[] T000113_n9AmgeStaGmail ;
      private String[] T000113_A10AmGePswEMail ;
      private bool[] T000113_n10AmGePswEMail ;
      private String[] T000113_A2AmgeUmedCd ;
      private bool[] T000113_n2AmgeUmedCd ;
      private String[] T000114_A1AmGecod ;
      private String[] T000111_A1AmGecod ;
      private String[] T000111_A7AmGedes ;
      private bool[] T000111_n7AmGedes ;
      private long[] T000111_A11AmGeval ;
      private bool[] T000111_n11AmGeval ;
      private String[] T000111_A12AmGedet ;
      private bool[] T000111_n12AmGedet ;
      private String[] T000111_A20AmgeAbr ;
      private bool[] T000111_n20AmgeAbr ;
      private String[] T000111_A8AmGesta ;
      private bool[] T000111_n8AmGesta ;
      private String[] T000111_A13AmGeobs ;
      private bool[] T000111_n13AmGeobs ;
      private short[] T000111_A14AmgeAnio ;
      private bool[] T000111_n14AmgeAnio ;
      private String[] T000111_A15AmGeusrlog ;
      private bool[] T000111_n15AmGeusrlog ;
      private DateTime[] T000111_A16AmGefeclog ;
      private bool[] T000111_n16AmGefeclog ;
      private String[] T000111_A17AmGehralog ;
      private bool[] T000111_n17AmGehralog ;
      private String[] T000111_A9AmgeStaGmail ;
      private bool[] T000111_n9AmgeStaGmail ;
      private String[] T000111_A10AmGePswEMail ;
      private bool[] T000111_n10AmGePswEMail ;
      private String[] T000111_A2AmgeUmedCd ;
      private bool[] T000111_n2AmgeUmedCd ;
      private String[] T000115_A1AmGecod ;
      private String[] T000116_A1AmGecod ;
      private String[] T000110_A1AmGecod ;
      private String[] T000110_A7AmGedes ;
      private bool[] T000110_n7AmGedes ;
      private long[] T000110_A11AmGeval ;
      private bool[] T000110_n11AmGeval ;
      private String[] T000110_A12AmGedet ;
      private bool[] T000110_n12AmGedet ;
      private String[] T000110_A20AmgeAbr ;
      private bool[] T000110_n20AmgeAbr ;
      private String[] T000110_A8AmGesta ;
      private bool[] T000110_n8AmGesta ;
      private String[] T000110_A13AmGeobs ;
      private bool[] T000110_n13AmGeobs ;
      private short[] T000110_A14AmgeAnio ;
      private bool[] T000110_n14AmgeAnio ;
      private String[] T000110_A15AmGeusrlog ;
      private bool[] T000110_n15AmGeusrlog ;
      private DateTime[] T000110_A16AmGefeclog ;
      private bool[] T000110_n16AmGefeclog ;
      private String[] T000110_A17AmGehralog ;
      private bool[] T000110_n17AmGehralog ;
      private String[] T000110_A9AmgeStaGmail ;
      private bool[] T000110_n9AmgeStaGmail ;
      private String[] T000110_A10AmGePswEMail ;
      private bool[] T000110_n10AmGePswEMail ;
      private String[] T000110_A2AmgeUmedCd ;
      private bool[] T000110_n2AmgeUmedCd ;
      private String[] T000120_A1AmGecod ;
      private String[] T000121_A1AmGecod ;
      private String[] T000121_A3AmgewsSec ;
      private short[] T000121_A21AmgeWsPort ;
      private String[] T000121_A22AmgeWsHost ;
      private String[] T000121_A23AmgeWsUri ;
      private String[] T000121_A24AmgeWsLoc ;
      private String[] T000121_A25AmgeWsTip ;
      private String[] T000121_A26AmgeWsEst ;
      private String[] T000122_A1AmGecod ;
      private String[] T000122_A3AmgewsSec ;
      private String[] T00019_A1AmGecod ;
      private String[] T00019_A3AmgewsSec ;
      private short[] T00019_A21AmgeWsPort ;
      private String[] T00019_A22AmgeWsHost ;
      private String[] T00019_A23AmgeWsUri ;
      private String[] T00019_A24AmgeWsLoc ;
      private String[] T00019_A25AmgeWsTip ;
      private String[] T00019_A26AmgeWsEst ;
      private String[] T00018_A1AmGecod ;
      private String[] T00018_A3AmgewsSec ;
      private short[] T00018_A21AmgeWsPort ;
      private String[] T00018_A22AmgeWsHost ;
      private String[] T00018_A23AmgeWsUri ;
      private String[] T00018_A24AmgeWsLoc ;
      private String[] T00018_A25AmgeWsTip ;
      private String[] T00018_A26AmgeWsEst ;
      private String[] T000126_A1AmGecod ;
      private String[] T000126_A3AmgewsSec ;
      private String[] T000127_A1AmGecod ;
      private String[] T000127_A4AmgeSec2 ;
      private short[] T000127_A27AmgeNoPesIni ;
      private bool[] T000127_n27AmgeNoPesIni ;
      private short[] T000127_A28AmgeNoPesTer ;
      private bool[] T000127_n28AmgeNoPesTer ;
      private decimal[] T000127_A29AmgeValPago ;
      private bool[] T000127_n29AmgeValPago ;
      private String[] T000128_A1AmGecod ;
      private String[] T000128_A4AmgeSec2 ;
      private String[] T00017_A1AmGecod ;
      private String[] T00017_A4AmgeSec2 ;
      private short[] T00017_A27AmgeNoPesIni ;
      private bool[] T00017_n27AmgeNoPesIni ;
      private short[] T00017_A28AmgeNoPesTer ;
      private bool[] T00017_n28AmgeNoPesTer ;
      private decimal[] T00017_A29AmgeValPago ;
      private bool[] T00017_n29AmgeValPago ;
      private String[] T00016_A1AmGecod ;
      private String[] T00016_A4AmgeSec2 ;
      private short[] T00016_A27AmgeNoPesIni ;
      private bool[] T00016_n27AmgeNoPesIni ;
      private short[] T00016_A28AmgeNoPesTer ;
      private bool[] T00016_n28AmgeNoPesTer ;
      private decimal[] T00016_A29AmgeValPago ;
      private bool[] T00016_n29AmgeValPago ;
      private String[] T000132_A1AmGecod ;
      private String[] T000132_A4AmgeSec2 ;
      private String[] T000133_A1AmGecod ;
      private String[] T000133_A5AmGeSec ;
      private String[] T000133_A30AmGeMail ;
      private bool[] T000133_n30AmGeMail ;
      private String[] T000134_A1AmGecod ;
      private String[] T000134_A5AmGeSec ;
      private String[] T00015_A1AmGecod ;
      private String[] T00015_A5AmGeSec ;
      private String[] T00015_A30AmGeMail ;
      private bool[] T00015_n30AmGeMail ;
      private String[] T00014_A1AmGecod ;
      private String[] T00014_A5AmGeSec ;
      private String[] T00014_A30AmGeMail ;
      private bool[] T00014_n30AmGeMail ;
      private String[] T000138_A1AmGecod ;
      private String[] T000138_A5AmGeSec ;
      private String[] T000139_A1AmGecod ;
      private String[] T000139_A43AmGeMailSec ;
      private short[] T000139_A44AmGeMailPort ;
      private String[] T000139_A45AmGeMailHost ;
      private String[] T000139_A46AmGeMailSender ;
      private String[] T000139_A47AmgeMailUser ;
      private String[] T000139_A48AmgeMailPassword ;
      private bool[] T000139_A49AmgeMailAuthentication ;
      private bool[] T000139_A50AmgeMailSecure ;
      private String[] T000139_A51AmgeMailEstado ;
      private String[] T000140_A1AmGecod ;
      private String[] T000140_A43AmGeMailSec ;
      private String[] T00013_A1AmGecod ;
      private String[] T00013_A43AmGeMailSec ;
      private short[] T00013_A44AmGeMailPort ;
      private String[] T00013_A45AmGeMailHost ;
      private String[] T00013_A46AmGeMailSender ;
      private String[] T00013_A47AmgeMailUser ;
      private String[] T00013_A48AmgeMailPassword ;
      private bool[] T00013_A49AmgeMailAuthentication ;
      private bool[] T00013_A50AmgeMailSecure ;
      private String[] T00013_A51AmgeMailEstado ;
      private String[] T00012_A1AmGecod ;
      private String[] T00012_A43AmGeMailSec ;
      private short[] T00012_A44AmGeMailPort ;
      private String[] T00012_A45AmGeMailHost ;
      private String[] T00012_A46AmGeMailSender ;
      private String[] T00012_A47AmgeMailUser ;
      private String[] T00012_A48AmgeMailPassword ;
      private bool[] T00012_A49AmgeMailAuthentication ;
      private bool[] T00012_A50AmgeMailSecure ;
      private String[] T00012_A51AmgeMailEstado ;
      private String[] T000144_A1AmGecod ;
      private String[] T000144_A43AmGeMailSec ;
      private IDataStoreProvider pr_sistema ;
      private GXWebForm Form ;
   }

   public class tagamge__sistema : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "SISTEMA";
    }

 }

 public class tagamge__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
       ,new ForEachCursor(def[3])
       ,new ForEachCursor(def[4])
       ,new ForEachCursor(def[5])
       ,new ForEachCursor(def[6])
       ,new ForEachCursor(def[7])
       ,new ForEachCursor(def[8])
       ,new ForEachCursor(def[9])
       ,new ForEachCursor(def[10])
       ,new ForEachCursor(def[11])
       ,new ForEachCursor(def[12])
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
       ,new UpdateCursor(def[15])
       ,new UpdateCursor(def[16])
       ,new UpdateCursor(def[17])
       ,new ForEachCursor(def[18])
       ,new ForEachCursor(def[19])
       ,new ForEachCursor(def[20])
       ,new UpdateCursor(def[21])
       ,new UpdateCursor(def[22])
       ,new UpdateCursor(def[23])
       ,new ForEachCursor(def[24])
       ,new ForEachCursor(def[25])
       ,new ForEachCursor(def[26])
       ,new UpdateCursor(def[27])
       ,new UpdateCursor(def[28])
       ,new UpdateCursor(def[29])
       ,new ForEachCursor(def[30])
       ,new ForEachCursor(def[31])
       ,new ForEachCursor(def[32])
       ,new UpdateCursor(def[33])
       ,new UpdateCursor(def[34])
       ,new UpdateCursor(def[35])
       ,new ForEachCursor(def[36])
       ,new ForEachCursor(def[37])
       ,new ForEachCursor(def[38])
       ,new UpdateCursor(def[39])
       ,new UpdateCursor(def[40])
       ,new UpdateCursor(def[41])
       ,new ForEachCursor(def[42])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000112 ;
        prmT000112 = new Object[] {
        new Object[] {"@AmgeUmedCd",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000113 ;
        prmT000113 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000114 ;
        prmT000114 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000111 ;
        prmT000111 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000115 ;
        prmT000115 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000116 ;
        prmT000116 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000110 ;
        prmT000110 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000117 ;
        prmT000117 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGedes",SqlDbType.NChar,30,0} ,
        new Object[] {"@AmGeval",SqlDbType.Decimal,10,0} ,
        new Object[] {"@AmGedet",SqlDbType.NChar,50,0} ,
        new Object[] {"@AmgeAbr",SqlDbType.NChar,3,0} ,
        new Object[] {"@AmGesta",SqlDbType.NChar,1,0} ,
        new Object[] {"@AmGeobs",SqlDbType.NVarChar,3000,0} ,
        new Object[] {"@AmgeAnio",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@AmGeusrlog",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGefeclog",SqlDbType.DateTime,8,0} ,
        new Object[] {"@AmGehralog",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgeStaGmail",SqlDbType.NChar,1,0} ,
        new Object[] {"@AmGePswEMail",SqlDbType.NChar,50,0} ,
        new Object[] {"@AmgeUmedCd",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000118 ;
        prmT000118 = new Object[] {
        new Object[] {"@AmGedes",SqlDbType.NChar,30,0} ,
        new Object[] {"@AmGeval",SqlDbType.Decimal,10,0} ,
        new Object[] {"@AmGedet",SqlDbType.NChar,50,0} ,
        new Object[] {"@AmgeAbr",SqlDbType.NChar,3,0} ,
        new Object[] {"@AmGesta",SqlDbType.NChar,1,0} ,
        new Object[] {"@AmGeobs",SqlDbType.NVarChar,3000,0} ,
        new Object[] {"@AmgeAnio",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@AmGeusrlog",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGefeclog",SqlDbType.DateTime,8,0} ,
        new Object[] {"@AmGehralog",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgeStaGmail",SqlDbType.NChar,1,0} ,
        new Object[] {"@AmGePswEMail",SqlDbType.NChar,50,0} ,
        new Object[] {"@AmgeUmedCd",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000119 ;
        prmT000119 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000120 ;
        prmT000120 = new Object[] {
        } ;
        Object[] prmT000121 ;
        prmT000121 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgewsSec",SqlDbType.NChar,3,0}
        } ;
        Object[] prmT000122 ;
        prmT000122 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgewsSec",SqlDbType.NChar,3,0}
        } ;
        Object[] prmT00019 ;
        prmT00019 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgewsSec",SqlDbType.NChar,3,0}
        } ;
        Object[] prmT00018 ;
        prmT00018 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgewsSec",SqlDbType.NChar,3,0}
        } ;
        Object[] prmT000123 ;
        prmT000123 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgewsSec",SqlDbType.NChar,3,0} ,
        new Object[] {"@AmgeWsPort",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@AmgeWsHost",SqlDbType.NChar,20,0} ,
        new Object[] {"@AmgeWsUri",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@AmgeWsLoc",SqlDbType.NChar,3,0} ,
        new Object[] {"@AmgeWsTip",SqlDbType.NChar,3,0} ,
        new Object[] {"@AmgeWsEst",SqlDbType.NChar,1,0}
        } ;
        Object[] prmT000124 ;
        prmT000124 = new Object[] {
        new Object[] {"@AmgeWsPort",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@AmgeWsHost",SqlDbType.NChar,20,0} ,
        new Object[] {"@AmgeWsUri",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@AmgeWsLoc",SqlDbType.NChar,3,0} ,
        new Object[] {"@AmgeWsTip",SqlDbType.NChar,3,0} ,
        new Object[] {"@AmgeWsEst",SqlDbType.NChar,1,0} ,
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgewsSec",SqlDbType.NChar,3,0}
        } ;
        Object[] prmT000125 ;
        prmT000125 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgewsSec",SqlDbType.NChar,3,0}
        } ;
        Object[] prmT000126 ;
        prmT000126 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000127 ;
        prmT000127 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgeSec2",SqlDbType.NChar,2,0}
        } ;
        Object[] prmT000128 ;
        prmT000128 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgeSec2",SqlDbType.NChar,2,0}
        } ;
        Object[] prmT00017 ;
        prmT00017 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgeSec2",SqlDbType.NChar,2,0}
        } ;
        Object[] prmT00016 ;
        prmT00016 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgeSec2",SqlDbType.NChar,2,0}
        } ;
        Object[] prmT000129 ;
        prmT000129 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgeSec2",SqlDbType.NChar,2,0} ,
        new Object[] {"@AmgeNoPesIni",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@AmgeNoPesTer",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@AmgeValPago",SqlDbType.Decimal,8,2}
        } ;
        Object[] prmT000130 ;
        prmT000130 = new Object[] {
        new Object[] {"@AmgeNoPesIni",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@AmgeNoPesTer",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@AmgeValPago",SqlDbType.Decimal,8,2} ,
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgeSec2",SqlDbType.NChar,2,0}
        } ;
        Object[] prmT000131 ;
        prmT000131 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmgeSec2",SqlDbType.NChar,2,0}
        } ;
        Object[] prmT000132 ;
        prmT000132 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000133 ;
        prmT000133 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeSec",SqlDbType.NChar,3,0}
        } ;
        Object[] prmT000134 ;
        prmT000134 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeSec",SqlDbType.NChar,3,0}
        } ;
        Object[] prmT00015 ;
        prmT00015 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeSec",SqlDbType.NChar,3,0}
        } ;
        Object[] prmT00014 ;
        prmT00014 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeSec",SqlDbType.NChar,3,0}
        } ;
        Object[] prmT000135 ;
        prmT000135 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeSec",SqlDbType.NChar,3,0} ,
        new Object[] {"@AmGeMail",SqlDbType.NChar,50,0}
        } ;
        Object[] prmT000136 ;
        prmT000136 = new Object[] {
        new Object[] {"@AmGeMail",SqlDbType.NChar,50,0} ,
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeSec",SqlDbType.NChar,3,0}
        } ;
        Object[] prmT000137 ;
        prmT000137 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeSec",SqlDbType.NChar,3,0}
        } ;
        Object[] prmT000138 ;
        prmT000138 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000139 ;
        prmT000139 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeMailSec",SqlDbType.NChar,2,0}
        } ;
        Object[] prmT000140 ;
        prmT000140 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeMailSec",SqlDbType.NChar,2,0}
        } ;
        Object[] prmT00013 ;
        prmT00013 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeMailSec",SqlDbType.NChar,2,0}
        } ;
        Object[] prmT00012 ;
        prmT00012 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeMailSec",SqlDbType.NChar,2,0}
        } ;
        Object[] prmT000141 ;
        prmT000141 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeMailSec",SqlDbType.NChar,2,0} ,
        new Object[] {"@AmGeMailPort",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@AmGeMailHost",SqlDbType.NVarChar,50,0} ,
        new Object[] {"@AmGeMailSender",SqlDbType.NVarChar,50,0} ,
        new Object[] {"@AmgeMailUser",SqlDbType.NVarChar,50,0} ,
        new Object[] {"@AmgeMailPassword",SqlDbType.NVarChar,60,0} ,
        new Object[] {"@AmgeMailAuthentication",SqlDbType.Bit,4,0} ,
        new Object[] {"@AmgeMailSecure",SqlDbType.Bit,4,0} ,
        new Object[] {"@AmgeMailEstado",SqlDbType.NChar,1,0}
        } ;
        Object[] prmT000142 ;
        prmT000142 = new Object[] {
        new Object[] {"@AmGeMailPort",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@AmGeMailHost",SqlDbType.NVarChar,50,0} ,
        new Object[] {"@AmGeMailSender",SqlDbType.NVarChar,50,0} ,
        new Object[] {"@AmgeMailUser",SqlDbType.NVarChar,50,0} ,
        new Object[] {"@AmgeMailPassword",SqlDbType.NVarChar,60,0} ,
        new Object[] {"@AmgeMailAuthentication",SqlDbType.Bit,4,0} ,
        new Object[] {"@AmgeMailSecure",SqlDbType.Bit,4,0} ,
        new Object[] {"@AmgeMailEstado",SqlDbType.NChar,1,0} ,
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeMailSec",SqlDbType.NChar,2,0}
        } ;
        Object[] prmT000143 ;
        prmT000143 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0} ,
        new Object[] {"@AmGeMailSec",SqlDbType.NChar,2,0}
        } ;
        Object[] prmT000144 ;
        prmT000144 = new Object[] {
        new Object[] {"@AmGecod",SqlDbType.NChar,5,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00012", "SELECT [AmGecod], [AmGeMailSec], [AmGeMailPort], [AmGeMailHost], [AmGeMailSender], [AmgeMailUser], [AmgeMailPassword], [AmgeMailAuthentication], [AmgeMailSecure], [AmgeMailEstado] FROM [AgAmGe4] WITH (UPDLOCK) WHERE [AmGecod] = @AmGecod AND [AmGeMailSec] = @AmGeMailSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00013", "SELECT [AmGecod], [AmGeMailSec], [AmGeMailPort], [AmGeMailHost], [AmGeMailSender], [AmgeMailUser], [AmgeMailPassword], [AmgeMailAuthentication], [AmgeMailSecure], [AmgeMailEstado] FROM [AgAmGe4] WHERE [AmGecod] = @AmGecod AND [AmGeMailSec] = @AmGeMailSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00014", "SELECT [AmGecod], [AmGeSec], [AmGeMail] FROM [agAmGe1] WITH (UPDLOCK) WHERE [AmGecod] = @AmGecod AND [AmGeSec] = @AmGeSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00015", "SELECT [AmGecod], [AmGeSec], [AmGeMail] FROM [agAmGe1] WHERE [AmGecod] = @AmGecod AND [AmGeSec] = @AmGeSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00016", "SELECT [AmGecod], [AmgeSec2], [AmgeNoPesIni], [AmgeNoPesTer], [AmgeValPago] FROM [AgAmGe2] WITH (UPDLOCK) WHERE [AmGecod] = @AmGecod AND [AmgeSec2] = @AmgeSec2 ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00017", "SELECT [AmGecod], [AmgeSec2], [AmgeNoPesIni], [AmgeNoPesTer], [AmgeValPago] FROM [AgAmGe2] WHERE [AmGecod] = @AmGecod AND [AmgeSec2] = @AmgeSec2 ",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00018", "SELECT [AmGecod], [AmgewsSec], [AmgeWsPort], [AmgeWsHost], [AmgeWsUri], [AmgeWsLoc], [AmgeWsTip], [AmgeWsEst] FROM [AgAmGe3] WITH (UPDLOCK) WHERE [AmGecod] = @AmGecod AND [AmgewsSec] = @AmgewsSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00019", "SELECT [AmGecod], [AmgewsSec], [AmgeWsPort], [AmgeWsHost], [AmgeWsUri], [AmgeWsLoc], [AmgeWsTip], [AmgeWsEst] FROM [AgAmGe3] WHERE [AmGecod] = @AmGecod AND [AmgewsSec] = @AmgewsSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000110", "SELECT [AmGecod], [AmGedes], [AmGeval], [AmGedet], [AmgeAbr], [AmGesta], [AmGeobs], [AmgeAnio], [AmGeusrlog], [AmGefeclog], [AmGehralog], [AmgeStaGmail], [AmGePswEMail], [AmgeUmedCd] AS AmgeUmedCd FROM [agAmGe] WITH (UPDLOCK) WHERE [AmGecod] = @AmGecod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000110,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000111", "SELECT [AmGecod], [AmGedes], [AmGeval], [AmGedet], [AmgeAbr], [AmGesta], [AmGeobs], [AmgeAnio], [AmGeusrlog], [AmGefeclog], [AmGehralog], [AmgeStaGmail], [AmGePswEMail], [AmgeUmedCd] AS AmgeUmedCd FROM [agAmGe] WHERE [AmGecod] = @AmGecod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000111,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000112", "SELECT [UmedDes] AS AmgeUmedDs FROM [agumed] WHERE [UmedCod] = @AmgeUmedCd ",true, GxErrorMask.GX_NOMASK, false, this,prmT000112,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000113", "SELECT TM1.[AmGecod], TM1.[AmGedes], TM1.[AmGeval], TM1.[AmGedet], TM1.[AmgeAbr], TM1.[AmGesta], TM1.[AmGeobs], TM1.[AmgeAnio], TM1.[AmGeusrlog], TM1.[AmGefeclog], TM1.[AmGehralog], T2.[UmedDes] AS AmgeUmedDs, TM1.[AmgeStaGmail], TM1.[AmGePswEMail], TM1.[AmgeUmedCd] AS AmgeUmedCd FROM ([agAmGe] TM1 LEFT JOIN [agumed] T2 ON T2.[UmedCod] = TM1.[AmgeUmedCd]) WHERE TM1.[AmGecod] = @AmGecod ORDER BY TM1.[AmGecod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000113,100, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000114", "SELECT [AmGecod] FROM [agAmGe] WHERE [AmGecod] = @AmGecod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000114,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000115", "SELECT TOP 1 [AmGecod] FROM [agAmGe] WHERE ( [AmGecod] > @AmGecod) ORDER BY [AmGecod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000115,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T000116", "SELECT TOP 1 [AmGecod] FROM [agAmGe] WHERE ( [AmGecod] < @AmGecod) ORDER BY [AmGecod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000116,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T000117", "INSERT INTO [agAmGe]([AmGecod], [AmGedes], [AmGeval], [AmGedet], [AmgeAbr], [AmGesta], [AmGeobs], [AmgeAnio], [AmGeusrlog], [AmGefeclog], [AmGehralog], [AmgeStaGmail], [AmGePswEMail], [AmgeUmedCd]) VALUES(@AmGecod, @AmGedes, @AmGeval, @AmGedet, @AmgeAbr, @AmGesta, @AmGeobs, @AmgeAnio, @AmGeusrlog, @AmGefeclog, @AmGehralog, @AmgeStaGmail, @AmGePswEMail, @AmgeUmedCd)", GxErrorMask.GX_NOMASK,prmT000117)
           ,new CursorDef("T000118", "UPDATE [agAmGe] SET [AmGedes]=@AmGedes, [AmGeval]=@AmGeval, [AmGedet]=@AmGedet, [AmgeAbr]=@AmgeAbr, [AmGesta]=@AmGesta, [AmGeobs]=@AmGeobs, [AmgeAnio]=@AmgeAnio, [AmGeusrlog]=@AmGeusrlog, [AmGefeclog]=@AmGefeclog, [AmGehralog]=@AmGehralog, [AmgeStaGmail]=@AmgeStaGmail, [AmGePswEMail]=@AmGePswEMail, [AmgeUmedCd]=@AmgeUmedCd  WHERE [AmGecod] = @AmGecod", GxErrorMask.GX_NOMASK,prmT000118)
           ,new CursorDef("T000119", "DELETE FROM [agAmGe]  WHERE [AmGecod] = @AmGecod", GxErrorMask.GX_NOMASK,prmT000119)
           ,new CursorDef("T000120", "SELECT [AmGecod] FROM [agAmGe] ORDER BY [AmGecod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000120,100, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000121", "SELECT [AmGecod], [AmgewsSec], [AmgeWsPort], [AmgeWsHost], [AmgeWsUri], [AmgeWsLoc], [AmgeWsTip], [AmgeWsEst] FROM [AgAmGe3] WHERE [AmGecod] = @AmGecod and [AmgewsSec] = @AmgewsSec ORDER BY [AmGecod], [AmgewsSec] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000121,11, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000122", "SELECT [AmGecod], [AmgewsSec] FROM [AgAmGe3] WHERE [AmGecod] = @AmGecod AND [AmgewsSec] = @AmgewsSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT000122,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000123", "INSERT INTO [AgAmGe3]([AmGecod], [AmgewsSec], [AmgeWsPort], [AmgeWsHost], [AmgeWsUri], [AmgeWsLoc], [AmgeWsTip], [AmgeWsEst]) VALUES(@AmGecod, @AmgewsSec, @AmgeWsPort, @AmgeWsHost, @AmgeWsUri, @AmgeWsLoc, @AmgeWsTip, @AmgeWsEst)", GxErrorMask.GX_NOMASK,prmT000123)
           ,new CursorDef("T000124", "UPDATE [AgAmGe3] SET [AmgeWsPort]=@AmgeWsPort, [AmgeWsHost]=@AmgeWsHost, [AmgeWsUri]=@AmgeWsUri, [AmgeWsLoc]=@AmgeWsLoc, [AmgeWsTip]=@AmgeWsTip, [AmgeWsEst]=@AmgeWsEst  WHERE [AmGecod] = @AmGecod AND [AmgewsSec] = @AmgewsSec", GxErrorMask.GX_NOMASK,prmT000124)
           ,new CursorDef("T000125", "DELETE FROM [AgAmGe3]  WHERE [AmGecod] = @AmGecod AND [AmgewsSec] = @AmgewsSec", GxErrorMask.GX_NOMASK,prmT000125)
           ,new CursorDef("T000126", "SELECT [AmGecod], [AmgewsSec] FROM [AgAmGe3] WHERE [AmGecod] = @AmGecod ORDER BY [AmGecod], [AmgewsSec] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000126,11, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000127", "SELECT [AmGecod], [AmgeSec2], [AmgeNoPesIni], [AmgeNoPesTer], [AmgeValPago] FROM [AgAmGe2] WHERE [AmGecod] = @AmGecod and [AmgeSec2] = @AmgeSec2 ORDER BY [AmGecod], [AmgeSec2] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000127,11, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000128", "SELECT [AmGecod], [AmgeSec2] FROM [AgAmGe2] WHERE [AmGecod] = @AmGecod AND [AmgeSec2] = @AmgeSec2 ",true, GxErrorMask.GX_NOMASK, false, this,prmT000128,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000129", "INSERT INTO [AgAmGe2]([AmGecod], [AmgeSec2], [AmgeNoPesIni], [AmgeNoPesTer], [AmgeValPago]) VALUES(@AmGecod, @AmgeSec2, @AmgeNoPesIni, @AmgeNoPesTer, @AmgeValPago)", GxErrorMask.GX_NOMASK,prmT000129)
           ,new CursorDef("T000130", "UPDATE [AgAmGe2] SET [AmgeNoPesIni]=@AmgeNoPesIni, [AmgeNoPesTer]=@AmgeNoPesTer, [AmgeValPago]=@AmgeValPago  WHERE [AmGecod] = @AmGecod AND [AmgeSec2] = @AmgeSec2", GxErrorMask.GX_NOMASK,prmT000130)
           ,new CursorDef("T000131", "DELETE FROM [AgAmGe2]  WHERE [AmGecod] = @AmGecod AND [AmgeSec2] = @AmgeSec2", GxErrorMask.GX_NOMASK,prmT000131)
           ,new CursorDef("T000132", "SELECT [AmGecod], [AmgeSec2] FROM [AgAmGe2] WHERE [AmGecod] = @AmGecod ORDER BY [AmGecod], [AmgeSec2] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000132,11, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000133", "SELECT [AmGecod], [AmGeSec], [AmGeMail] FROM [agAmGe1] WHERE [AmGecod] = @AmGecod and [AmGeSec] = @AmGeSec ORDER BY [AmGecod], [AmGeSec] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000133,11, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000134", "SELECT [AmGecod], [AmGeSec] FROM [agAmGe1] WHERE [AmGecod] = @AmGecod AND [AmGeSec] = @AmGeSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT000134,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000135", "INSERT INTO [agAmGe1]([AmGecod], [AmGeSec], [AmGeMail]) VALUES(@AmGecod, @AmGeSec, @AmGeMail)", GxErrorMask.GX_NOMASK,prmT000135)
           ,new CursorDef("T000136", "UPDATE [agAmGe1] SET [AmGeMail]=@AmGeMail  WHERE [AmGecod] = @AmGecod AND [AmGeSec] = @AmGeSec", GxErrorMask.GX_NOMASK,prmT000136)
           ,new CursorDef("T000137", "DELETE FROM [agAmGe1]  WHERE [AmGecod] = @AmGecod AND [AmGeSec] = @AmGeSec", GxErrorMask.GX_NOMASK,prmT000137)
           ,new CursorDef("T000138", "SELECT [AmGecod], [AmGeSec] FROM [agAmGe1] WHERE [AmGecod] = @AmGecod ORDER BY [AmGecod], [AmGeSec] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000138,11, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000139", "SELECT [AmGecod], [AmGeMailSec], [AmGeMailPort], [AmGeMailHost], [AmGeMailSender], [AmgeMailUser], [AmgeMailPassword], [AmgeMailAuthentication], [AmgeMailSecure], [AmgeMailEstado] FROM [AgAmGe4] WHERE [AmGecod] = @AmGecod and [AmGeMailSec] = @AmGeMailSec ORDER BY [AmGecod], [AmGeMailSec] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000139,11, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000140", "SELECT [AmGecod], [AmGeMailSec] FROM [AgAmGe4] WHERE [AmGecod] = @AmGecod AND [AmGeMailSec] = @AmGeMailSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT000140,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T000141", "INSERT INTO [AgAmGe4]([AmGecod], [AmGeMailSec], [AmGeMailPort], [AmGeMailHost], [AmGeMailSender], [AmgeMailUser], [AmgeMailPassword], [AmgeMailAuthentication], [AmgeMailSecure], [AmgeMailEstado]) VALUES(@AmGecod, @AmGeMailSec, @AmGeMailPort, @AmGeMailHost, @AmGeMailSender, @AmgeMailUser, @AmgeMailPassword, @AmgeMailAuthentication, @AmgeMailSecure, @AmgeMailEstado)", GxErrorMask.GX_NOMASK,prmT000141)
           ,new CursorDef("T000142", "UPDATE [AgAmGe4] SET [AmGeMailPort]=@AmGeMailPort, [AmGeMailHost]=@AmGeMailHost, [AmGeMailSender]=@AmGeMailSender, [AmgeMailUser]=@AmgeMailUser, [AmgeMailPassword]=@AmgeMailPassword, [AmgeMailAuthentication]=@AmgeMailAuthentication, [AmgeMailSecure]=@AmgeMailSecure, [AmgeMailEstado]=@AmgeMailEstado  WHERE [AmGecod] = @AmGecod AND [AmGeMailSec] = @AmGeMailSec", GxErrorMask.GX_NOMASK,prmT000142)
           ,new CursorDef("T000143", "DELETE FROM [AgAmGe4]  WHERE [AmGecod] = @AmGecod AND [AmGeMailSec] = @AmGeMailSec", GxErrorMask.GX_NOMASK,prmT000143)
           ,new CursorDef("T000144", "SELECT [AmGecod], [AmGeMailSec] FROM [AgAmGe4] WHERE [AmGecod] = @AmGecod ORDER BY [AmGecod], [AmGeMailSec] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000144,11, GxCacheFrequency.OFF ,true,false )
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
              ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
              ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[7])[0] = rslt.getBool(8) ;
              ((bool[]) buf[8])[0] = rslt.getBool(9) ;
              ((String[]) buf[9])[0] = rslt.getString(10, 1) ;
              return;
           case 1 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
              ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[7])[0] = rslt.getBool(8) ;
              ((bool[]) buf[8])[0] = rslt.getBool(9) ;
              ((String[]) buf[9])[0] = rslt.getString(10, 1) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
              ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
              ((bool[]) buf[3])[0] = rslt.wasNull(3);
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
              ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
              ((bool[]) buf[3])[0] = rslt.wasNull(3);
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((bool[]) buf[3])[0] = rslt.wasNull(3);
              ((short[]) buf[4])[0] = rslt.getShort(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              ((decimal[]) buf[6])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[7])[0] = rslt.wasNull(5);
              return;
           case 5 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((bool[]) buf[3])[0] = rslt.wasNull(3);
              ((short[]) buf[4])[0] = rslt.getShort(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              ((decimal[]) buf[6])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[7])[0] = rslt.wasNull(5);
              return;
           case 6 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getString(6, 3) ;
              ((String[]) buf[6])[0] = rslt.getString(7, 3) ;
              ((String[]) buf[7])[0] = rslt.getString(8, 1) ;
              return;
           case 7 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getString(6, 3) ;
              ((String[]) buf[6])[0] = rslt.getString(7, 3) ;
              ((String[]) buf[7])[0] = rslt.getString(8, 1) ;
              return;
           case 8 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getString(4, 50) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getString(5, 3) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getString(6, 1) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getLongVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((short[]) buf[13])[0] = rslt.getShort(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getString(9, 5) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getString(11, 5) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getString(12, 1) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getString(13, 50) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getString(14, 5) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              return;
           case 9 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getString(4, 50) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getString(5, 3) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getString(6, 1) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getLongVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((short[]) buf[13])[0] = rslt.getShort(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getString(9, 5) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getString(11, 5) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getString(12, 1) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getString(13, 50) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getString(14, 5) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              return;
           case 10 :
              ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
              return;
           case 11 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getString(4, 50) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getString(5, 3) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getString(6, 1) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getLongVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((short[]) buf[13])[0] = rslt.getShort(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getString(9, 5) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getString(11, 5) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getString(12, 15) ;
              ((String[]) buf[22])[0] = rslt.getString(13, 1) ;
              ((bool[]) buf[23])[0] = rslt.wasNull(13);
              ((String[]) buf[24])[0] = rslt.getString(14, 50) ;
              ((bool[]) buf[25])[0] = rslt.wasNull(14);
              ((String[]) buf[26])[0] = rslt.getString(15, 5) ;
              ((bool[]) buf[27])[0] = rslt.wasNull(15);
              return;
           case 12 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              return;
           case 13 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              return;
           case 14 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              return;
           case 18 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              return;
           case 19 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getString(6, 3) ;
              ((String[]) buf[6])[0] = rslt.getString(7, 3) ;
              ((String[]) buf[7])[0] = rslt.getString(8, 1) ;
              return;
           case 20 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
              return;
           case 24 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
              return;
           case 25 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((bool[]) buf[3])[0] = rslt.wasNull(3);
              ((short[]) buf[4])[0] = rslt.getShort(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              ((decimal[]) buf[6])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[7])[0] = rslt.wasNull(5);
              return;
           case 26 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
              return;
     }
     getresults30( cursor, rslt, buf) ;
  }

  public void getresults30( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
  {
     switch ( cursor )
     {
           case 30 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
              return;
           case 31 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
              ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
              ((bool[]) buf[3])[0] = rslt.wasNull(3);
              return;
           case 32 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
              return;
           case 36 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
              return;
           case 37 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
              ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[7])[0] = rslt.getBool(8) ;
              ((bool[]) buf[8])[0] = rslt.getBool(9) ;
              ((String[]) buf[9])[0] = rslt.getString(10, 1) ;
              return;
           case 38 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
              return;
           case 42 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
              return;
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
           case 0 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 1 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 2 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 3 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 4 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 5 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 6 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 7 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 8 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 10 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              return;
           case 11 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 12 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 13 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 14 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 15 :
              stmt.SetParameter(1, (String)parms[0]);
              if ( (bool)parms[1] )
              {
                 stmt.setNull( 2 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[2]);
              }
              if ( (bool)parms[3] )
              {
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (long)parms[4]);
              }
              if ( (bool)parms[5] )
              {
                 stmt.setNull( 4 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[6]);
              }
              if ( (bool)parms[7] )
              {
                 stmt.setNull( 5 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[8]);
              }
              if ( (bool)parms[9] )
              {
                 stmt.setNull( 6 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[10]);
              }
              if ( (bool)parms[11] )
              {
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[12]);
              }
              if ( (bool)parms[13] )
              {
                 stmt.setNull( 8 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(8, (short)parms[14]);
              }
              if ( (bool)parms[15] )
              {
                 stmt.setNull( 9 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(9, (String)parms[16]);
              }
              if ( (bool)parms[17] )
              {
                 stmt.setNull( 10 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(10, (DateTime)parms[18]);
              }
              if ( (bool)parms[19] )
              {
                 stmt.setNull( 11 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[20]);
              }
              if ( (bool)parms[21] )
              {
                 stmt.setNull( 12 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(12, (String)parms[22]);
              }
              if ( (bool)parms[23] )
              {
                 stmt.setNull( 13 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(13, (String)parms[24]);
              }
              if ( (bool)parms[25] )
              {
                 stmt.setNull( 14 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(14, (String)parms[26]);
              }
              return;
           case 16 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(2, (long)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(7, (short)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(8, (String)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(9, (DateTime)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(10, (String)parms[19]);
              }
              if ( (bool)parms[20] )
              {
                 stmt.setNull( 11 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(12, (String)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(13, (String)parms[25]);
              }
              stmt.SetParameter(14, (String)parms[26]);
              return;
           case 17 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 19 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 20 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 21 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (String)parms[4]);
              stmt.SetParameter(6, (String)parms[5]);
              stmt.SetParameter(7, (String)parms[6]);
              stmt.SetParameter(8, (String)parms[7]);
              return;
           case 22 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (String)parms[4]);
              stmt.SetParameter(6, (String)parms[5]);
              stmt.SetParameter(7, (String)parms[6]);
              stmt.SetParameter(8, (String)parms[7]);
              return;
           case 23 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 24 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 25 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 26 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 27 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 3 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(3, (short)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 4 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(4, (short)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (decimal)parms[7]);
              }
              return;
           case 28 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(1, (short)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (decimal)parms[5]);
              }
              stmt.SetParameter(4, (String)parms[6]);
              stmt.SetParameter(5, (String)parms[7]);
              return;
           case 29 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
     }
     setparameters30( cursor, stmt, parms) ;
  }

  public void setparameters30( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
  {
     switch ( cursor )
     {
           case 30 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 31 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 32 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 33 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 3 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[3]);
              }
              return;
           case 34 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              stmt.SetParameter(2, (String)parms[2]);
              stmt.SetParameter(3, (String)parms[3]);
              return;
           case 35 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 36 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 37 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 38 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 39 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (String)parms[4]);
              stmt.SetParameter(6, (String)parms[5]);
              stmt.SetParameter(7, (String)parms[6]);
              stmt.SetParameter(8, (bool)parms[7]);
              stmt.SetParameter(9, (bool)parms[8]);
              stmt.SetParameter(10, (String)parms[9]);
              return;
           case 40 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (String)parms[4]);
              stmt.SetParameter(6, (bool)parms[5]);
              stmt.SetParameter(7, (bool)parms[6]);
              stmt.SetParameter(8, (String)parms[7]);
              stmt.SetParameter(9, (String)parms[8]);
              stmt.SetParameter(10, (String)parms[9]);
              return;
           case 41 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 42 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
     }
  }

}

}
