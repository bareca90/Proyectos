/*
               File: Tagumed
        Description: Unidades de medida
             Author: GeneXus C# Generator version 16_0_11-144151
       Generated on: 4/21/2022 10:26:29.93
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
   public class tagumed : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action4") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_4_025( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action5") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_5_025( ) ;
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
            Form.Meta.addItem("description", "Unidades de medida", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         if ( ! context.isAjaxRequest( ) )
         {
            GX_FocusControl = edtUmedCod_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public tagumed( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsSistema = context.GetDataStore("Sistema");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public tagumed( IGxContext context )
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
         /* Table start */
         sStyleString = "";
         GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
         context.WriteHtmlText( "<tbody>") ;
         context.WriteHtmlText( "<tr>") ;
         context.WriteHtmlText( "<td>") ;
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 5,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tagumed.htm");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 6,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tagumed.htm");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 7,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tagumed.htm");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tagumed.htm");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0050.aspx"+"',["+"{Ctrl:gx.dom.el('"+"UMEDCOD"+"'), id:'"+"UMEDCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "</tr>") ;
         context.WriteHtmlText( "<tr>") ;
         context.WriteHtmlText( "<td>") ;
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "</tr>") ;
         context.WriteHtmlText( "<tr>") ;
         context.WriteHtmlText( "<td>") ;
         /* Table start */
         sStyleString = "";
         GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
         context.WriteHtmlText( "<tbody>") ;
         context.WriteHtmlText( "<tr>") ;
         context.WriteHtmlText( "<td>") ;
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Código de Unid.de Medida:", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "<td>") ;
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtUmedCod_Internalname, StringUtil.RTrim( A6UmedCod), StringUtil.RTrim( context.localUtil.Format( A6UmedCod, "99999")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,20);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUmedCod_Jsonclick, 0, "", "", "", "", "", 1, edtUmedCod_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 0, -1, -1, true, "codmediano", "left", true, "", "HLP_Tagumed.htm");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_get_Internalname, "", "=>", bttBtn_get_Jsonclick, 6, "=>", "", StyleString, ClassString, bttBtn_get_Visible, bttBtn_get_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EGET."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "</tr>") ;
         context.WriteHtmlText( "<tr>") ;
         context.WriteHtmlText( "<td>") ;
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "Descripción:", "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "<td>") ;
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtUmedDes_Internalname, StringUtil.RTrim( A19UmedDes), StringUtil.RTrim( context.localUtil.Format( A19UmedDes, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUmedDes_Jsonclick, 0, "", "", "", "", "", 1, edtUmedDes_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 0, -1, -1, true, "nomcorto", "left", true, "", "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "</tr>") ;
         context.WriteHtmlText( "<tr>") ;
         context.WriteHtmlText( "<td>") ;
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Abreviatura:", "", "", lblTextblock3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "<td>") ;
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtumedabr_Internalname, StringUtil.RTrim( A31umedabr), StringUtil.RTrim( context.localUtil.Format( A31umedabr, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,31);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtumedabr_Jsonclick, 0, "", "", "", "", "", 1, edtumedabr_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 0, -1, -1, true, "", "left", true, "", "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "</tr>") ;
         context.WriteHtmlText( "<tr>") ;
         context.WriteHtmlText( "<td>") ;
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Presentación", "", "", lblTextblock4_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "<td>") ;
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtumedpre_Internalname, StringUtil.RTrim( A32umedpre), StringUtil.RTrim( context.localUtil.Format( A32umedpre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtumedpre_Jsonclick, 0, "", "", "", "", "", 1, edtumedpre_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 0, -1, -1, true, "", "left", true, "", "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "</tr>") ;
         context.WriteHtmlText( "<tr>") ;
         context.WriteHtmlText( "<td>") ;
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "Libras Kilos o Unidades", "", "", lblTextblock5_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "<td>") ;
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtumedLKU_Internalname, StringUtil.RTrim( A33umedLKU), StringUtil.RTrim( context.localUtil.Format( A33umedLKU, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,41);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtumedLKU_Jsonclick, 0, "", "", "", "", "", 1, edtumedLKU_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 0, -1, -1, true, "", "left", true, "", "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "</tr>") ;
         context.WriteHtmlText( "<tr>") ;
         context.WriteHtmlText( "<td>") ;
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, "Status de Uso en Ventas", "", "", lblTextblock6_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "<td>") ;
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtumevtasta_Internalname, StringUtil.RTrim( A34umevtasta), StringUtil.RTrim( context.localUtil.Format( A34umevtasta, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtumevtasta_Jsonclick, 0, "", "", "", "", "", 1, edtumevtasta_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 0, -1, -1, true, "", "left", true, "", "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "</tr>") ;
         context.WriteHtmlText( "<tr>") ;
         context.WriteHtmlText( "<td>") ;
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, "umedusrlog", "", "", lblTextblock7_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "<td>") ;
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtumedusrlog_Internalname, StringUtil.RTrim( A35umedusrlog), StringUtil.RTrim( context.localUtil.Format( A35umedusrlog, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtumedusrlog_Jsonclick, 0, "", "", "", "", "", 1, edtumedusrlog_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 0, -1, -1, true, "", "left", true, "", "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "</tr>") ;
         context.WriteHtmlText( "<tr>") ;
         context.WriteHtmlText( "<td>") ;
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, "umedfeclog", "", "", lblTextblock8_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "<td>") ;
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
         context.WriteHtmlText( "<div id=\""+edtumedfeclog_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
         GxWebStd.gx_single_line_edit( context, edtumedfeclog_Internalname, context.localUtil.TToC( A36umedfeclog, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A36umedfeclog, "99/99/9999 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtumedfeclog_Jsonclick, 0, "", "", "", "", "", 1, edtumedfeclog_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 0, -1, 0, true, "", "right", false, "", "HLP_Tagumed.htm");
         GxWebStd.gx_bitmap( context, edtumedfeclog_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtumedfeclog_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Tagumed.htm");
         context.WriteHtmlTextNl( "</div>") ;
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "</tr>") ;
         context.WriteHtmlText( "<tr>") ;
         context.WriteHtmlText( "<td>") ;
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, "umedhralog", "", "", lblTextblock9_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "<td>") ;
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtumedhralog_Internalname, StringUtil.RTrim( A37umedhralog), StringUtil.RTrim( context.localUtil.Format( A37umedhralog, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtumedhralog_Jsonclick, 0, "", "", "", "", "", 1, edtumedhralog_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 0, -1, -1, true, "", "left", true, "", "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "</tr>") ;
         context.WriteHtmlText( "</tbody>") ;
         /* End of table */
         context.WriteHtmlText( "</table>") ;
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "</tr>") ;
         context.WriteHtmlText( "<tr>") ;
         context.WriteHtmlText( "<td>") ;
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tagumed.htm");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_check_Internalname, "", "Verificar", bttBtn_check_Jsonclick, 5, "Verificar", "", StyleString, ClassString, bttBtn_check_Visible, bttBtn_check_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"ECHECK."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tagumed.htm");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tagumed.htm");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tagumed.htm");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
         ClassString = "";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_help_Internalname, "", "Ayuda", bttBtn_help_Jsonclick, 3, "Ayuda", "", StyleString, ClassString, bttBtn_help_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EHELP."+"'", TempTags, "", 2, "HLP_Tagumed.htm");
         context.WriteHtmlText( "</td>") ;
         context.WriteHtmlText( "</tr>") ;
         context.WriteHtmlText( "</tbody>") ;
         /* End of table */
         context.WriteHtmlText( "</table>") ;
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
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11022 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z6UmedCod = cgiGet( "Z6UmedCod");
               Z19UmedDes = cgiGet( "Z19UmedDes");
               Z31umedabr = cgiGet( "Z31umedabr");
               Z32umedpre = cgiGet( "Z32umedpre");
               Z33umedLKU = cgiGet( "Z33umedLKU");
               Z34umevtasta = cgiGet( "Z34umevtasta");
               Z38UmedDesEti = cgiGet( "Z38UmedDesEti");
               n38UmedDesEti = (String.IsNullOrEmpty(StringUtil.RTrim( A38UmedDesEti)) ? true : false);
               Z35umedusrlog = cgiGet( "Z35umedusrlog");
               Z36umedfeclog = context.localUtil.CToT( cgiGet( "Z36umedfeclog"), 0);
               Z37umedhralog = cgiGet( "Z37umedhralog");
               A38UmedDesEti = cgiGet( "Z38UmedDesEti");
               n38UmedDesEti = false;
               n38UmedDesEti = (String.IsNullOrEmpty(StringUtil.RTrim( A38UmedDesEti)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               A38UmedDesEti = cgiGet( "UMEDDESETI");
               n38UmedDesEti = (String.IsNullOrEmpty(StringUtil.RTrim( A38UmedDesEti)) ? true : false);
               AV13Pgmname = cgiGet( "vPGMNAME");
               /* Read variables values. */
               A6UmedCod = cgiGet( edtUmedCod_Internalname);
               AssignAttri("", false, "A6UmedCod", A6UmedCod);
               A19UmedDes = StringUtil.Upper( cgiGet( edtUmedDes_Internalname));
               AssignAttri("", false, "A19UmedDes", A19UmedDes);
               A31umedabr = cgiGet( edtumedabr_Internalname);
               AssignAttri("", false, "A31umedabr", A31umedabr);
               A32umedpre = cgiGet( edtumedpre_Internalname);
               AssignAttri("", false, "A32umedpre", A32umedpre);
               A33umedLKU = cgiGet( edtumedLKU_Internalname);
               AssignAttri("", false, "A33umedLKU", A33umedLKU);
               A34umevtasta = cgiGet( edtumevtasta_Internalname);
               AssignAttri("", false, "A34umevtasta", A34umevtasta);
               A35umedusrlog = cgiGet( edtumedusrlog_Internalname);
               AssignAttri("", false, "A35umedusrlog", A35umedusrlog);
               if ( context.localUtil.VCDateTime( cgiGet( edtumedfeclog_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"umedfeclog"}), 1, "UMEDFECLOG");
                  AnyError = 1;
                  GX_FocusControl = edtumedfeclog_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A36umedfeclog = (DateTime)(DateTime.MinValue);
                  AssignAttri("", false, "A36umedfeclog", context.localUtil.TToC( A36umedfeclog, 10, 8, 0, 3, "/", ":", " "));
               }
               else
               {
                  A36umedfeclog = context.localUtil.CToT( cgiGet( edtumedfeclog_Internalname));
                  AssignAttri("", false, "A36umedfeclog", context.localUtil.TToC( A36umedfeclog, 10, 8, 0, 3, "/", ":", " "));
               }
               A37umedhralog = cgiGet( edtumedhralog_Internalname);
               AssignAttri("", false, "A37umedhralog", A37umedhralog);
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"Tagumed");
               forbiddenHiddens.Add("UmedDesEti", StringUtil.RTrim( context.localUtil.Format( A38UmedDesEti, "")));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( StringUtil.StrCmp(A6UmedCod, Z6UmedCod) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLogError("tagumed:[ SecurityCheckFailed (403 Forbidden) value for]"+forbiddenHiddens.ToJSonString());
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
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  A6UmedCod = GetNextPar( );
                  AssignAttri("", false, "A6UmedCod", A6UmedCod);
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
                        if ( StringUtil.StrCmp(sEvt, "'IMPRIMIR'") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'imprimir' */
                           E12022 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11022 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
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
               InitAll025( ) ;
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
         DisableAttributes025( ) ;
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

      protected void CONFIRM_020( )
      {
         BeforeValidate025( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls025( ) ;
            }
            else
            {
               CheckExtendedTable025( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors025( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         }
         if ( AnyError == 0 )
         {
            ConfirmValues020( ) ;
         }
      }

      protected void ResetCaption020( )
      {
      }

      protected void E12022( )
      {
         /* 'imprimir' Routine */
         new ragumed(context ).execute( ) ;
      }

      protected void E11022( )
      {
         /* Start Routine */
         AV7m_nomtra = AV13Pgmname;
         AssignAttri("", false, "AV7m_nomtra", AV7m_nomtra);
         AV7m_nomtra = StringUtil.Upper( AV7m_nomtra);
         AssignAttri("", false, "AV7m_nomtra", AV7m_nomtra);
         AV7m_nomtra = StringUtil.RTrim( AV7m_nomtra);
         AssignAttri("", false, "AV7m_nomtra", AV7m_nomtra);
         new psecall1(context ).execute( ref  AV7m_nomtra, ref  AV8m_staac, ref  AV11m_opciones, ref  AV9m_usuacod) ;
         AssignAttri("", false, "AV7m_nomtra", AV7m_nomtra);
         AssignAttri("", false, "AV8m_staac", AV8m_staac);
         AssignAttri("", false, "AV11m_opciones", AV11m_opciones);
         AssignAttri("", false, "AV9m_usuacod", AV9m_usuacod);
         if ( ! ( StringUtil.StrCmp(AV8m_staac, "X") == 0 ) )
         {
            context.setWebReturnParms(new Object[] {});
            context.setWebReturnParmsMetadata(new Object[] {});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
      }

      protected void ZM025( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z19UmedDes = T00023_A19UmedDes[0];
               Z31umedabr = T00023_A31umedabr[0];
               Z32umedpre = T00023_A32umedpre[0];
               Z33umedLKU = T00023_A33umedLKU[0];
               Z34umevtasta = T00023_A34umevtasta[0];
               Z38UmedDesEti = T00023_A38UmedDesEti[0];
               Z35umedusrlog = T00023_A35umedusrlog[0];
               Z36umedfeclog = T00023_A36umedfeclog[0];
               Z37umedhralog = T00023_A37umedhralog[0];
            }
            else
            {
               Z19UmedDes = A19UmedDes;
               Z31umedabr = A31umedabr;
               Z32umedpre = A32umedpre;
               Z33umedLKU = A33umedLKU;
               Z34umevtasta = A34umevtasta;
               Z38UmedDesEti = A38UmedDesEti;
               Z35umedusrlog = A35umedusrlog;
               Z36umedfeclog = A36umedfeclog;
               Z37umedhralog = A37umedhralog;
            }
         }
         if ( GX_JID == -6 )
         {
            Z6UmedCod = A6UmedCod;
            Z19UmedDes = A19UmedDes;
            Z31umedabr = A31umedabr;
            Z32umedpre = A32umedpre;
            Z33umedLKU = A33umedLKU;
            Z34umevtasta = A34umevtasta;
            Z38UmedDesEti = A38UmedDesEti;
            Z35umedusrlog = A35umedusrlog;
            Z36umedfeclog = A36umedfeclog;
            Z37umedhralog = A37umedhralog;
         }
      }

      protected void standaloneNotModal( )
      {
         AV13Pgmname = "Tagumed";
         AssignAttri("", false, "AV13Pgmname", AV13Pgmname);
         Gx_BScreen = 0;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
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
         if ( IsIns( )  && String.IsNullOrEmpty(StringUtil.RTrim( A33umedLKU)) && ( Gx_BScreen == 0 ) )
         {
            A33umedLKU = " ";
            AssignAttri("", false, "A33umedLKU", A33umedLKU);
         }
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

      protected void Load025( )
      {
         /* Using cursor T00024 */
         pr_default.execute(2, new Object[] {A6UmedCod});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound5 = 1;
            A19UmedDes = T00024_A19UmedDes[0];
            AssignAttri("", false, "A19UmedDes", A19UmedDes);
            A31umedabr = T00024_A31umedabr[0];
            AssignAttri("", false, "A31umedabr", A31umedabr);
            A32umedpre = T00024_A32umedpre[0];
            AssignAttri("", false, "A32umedpre", A32umedpre);
            A33umedLKU = T00024_A33umedLKU[0];
            AssignAttri("", false, "A33umedLKU", A33umedLKU);
            A34umevtasta = T00024_A34umevtasta[0];
            AssignAttri("", false, "A34umevtasta", A34umevtasta);
            A38UmedDesEti = T00024_A38UmedDesEti[0];
            n38UmedDesEti = T00024_n38UmedDesEti[0];
            A35umedusrlog = T00024_A35umedusrlog[0];
            AssignAttri("", false, "A35umedusrlog", A35umedusrlog);
            A36umedfeclog = T00024_A36umedfeclog[0];
            AssignAttri("", false, "A36umedfeclog", context.localUtil.TToC( A36umedfeclog, 10, 8, 0, 3, "/", ":", " "));
            A37umedhralog = T00024_A37umedhralog[0];
            AssignAttri("", false, "A37umedhralog", A37umedhralog);
            ZM025( -6) ;
         }
         pr_default.close(2);
         OnLoadActions025( ) ;
      }

      protected void OnLoadActions025( )
      {
      }

      protected void CheckExtendedTable025( )
      {
         nIsDirty_5 = 0;
         Gx_BScreen = 1;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         if ( true /* After */ && IsIns( )  )
         {
            GXt_char1 = "UMED";
            GXt_int2 = 5;
            GXt_int3 = 0;
            new pnuevocod(context ).execute( ref  GXt_char1, ref  GXt_int2, ref  A6UmedCod, ref  GXt_int3) ;
            AssignAttri("", false, "A6UmedCod", A6UmedCod);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A19UmedDes)) )
         {
            GX_msglist.addItem("Ingrese nombre", 1, "UMEDDES");
            AnyError = 1;
            GX_FocusControl = edtUmedDes_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A36umedfeclog) || ( A36umedfeclog >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo umedfeclog fuera de rango", "OutOfRange", 1, "UMEDFECLOG");
            AnyError = 1;
            GX_FocusControl = edtumedfeclog_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors025( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey025( )
      {
         /* Using cursor T00025 */
         pr_default.execute(3, new Object[] {A6UmedCod});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {A6UmedCod});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM025( 6) ;
            RcdFound5 = 1;
            A6UmedCod = T00023_A6UmedCod[0];
            AssignAttri("", false, "A6UmedCod", A6UmedCod);
            A19UmedDes = T00023_A19UmedDes[0];
            AssignAttri("", false, "A19UmedDes", A19UmedDes);
            A31umedabr = T00023_A31umedabr[0];
            AssignAttri("", false, "A31umedabr", A31umedabr);
            A32umedpre = T00023_A32umedpre[0];
            AssignAttri("", false, "A32umedpre", A32umedpre);
            A33umedLKU = T00023_A33umedLKU[0];
            AssignAttri("", false, "A33umedLKU", A33umedLKU);
            A34umevtasta = T00023_A34umevtasta[0];
            AssignAttri("", false, "A34umevtasta", A34umevtasta);
            A38UmedDesEti = T00023_A38UmedDesEti[0];
            n38UmedDesEti = T00023_n38UmedDesEti[0];
            A35umedusrlog = T00023_A35umedusrlog[0];
            AssignAttri("", false, "A35umedusrlog", A35umedusrlog);
            A36umedfeclog = T00023_A36umedfeclog[0];
            AssignAttri("", false, "A36umedfeclog", context.localUtil.TToC( A36umedfeclog, 10, 8, 0, 3, "/", ":", " "));
            A37umedhralog = T00023_A37umedhralog[0];
            AssignAttri("", false, "A37umedhralog", A37umedhralog);
            Z6UmedCod = A6UmedCod;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load025( ) ;
            if ( AnyError == 1 )
            {
               RcdFound5 = 0;
               InitializeNonKey025( ) ;
            }
            Gx_mode = sMode5;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey025( ) ;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode5;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey025( ) ;
         if ( RcdFound5 == 0 )
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
         RcdFound5 = 0;
         /* Using cursor T00026 */
         pr_default.execute(4, new Object[] {A6UmedCod});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T00026_A6UmedCod[0], A6UmedCod) < 0 ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T00026_A6UmedCod[0], A6UmedCod) > 0 ) ) )
            {
               A6UmedCod = T00026_A6UmedCod[0];
               AssignAttri("", false, "A6UmedCod", A6UmedCod);
               RcdFound5 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound5 = 0;
         /* Using cursor T00027 */
         pr_default.execute(5, new Object[] {A6UmedCod});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T00027_A6UmedCod[0], A6UmedCod) > 0 ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T00027_A6UmedCod[0], A6UmedCod) < 0 ) ) )
            {
               A6UmedCod = T00027_A6UmedCod[0];
               AssignAttri("", false, "A6UmedCod", A6UmedCod);
               RcdFound5 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey025( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtUmedCod_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert025( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound5 == 1 )
            {
               if ( StringUtil.StrCmp(A6UmedCod, Z6UmedCod) != 0 )
               {
                  A6UmedCod = Z6UmedCod;
                  AssignAttri("", false, "A6UmedCod", A6UmedCod);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "UMEDCOD");
                  AnyError = 1;
                  GX_FocusControl = edtUmedCod_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtUmedCod_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update025( ) ;
                  GX_FocusControl = edtUmedCod_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(A6UmedCod, Z6UmedCod) != 0 )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtUmedCod_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert025( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "UMEDCOD");
                     AnyError = 1;
                     GX_FocusControl = edtUmedCod_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtUmedCod_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert025( ) ;
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
         if ( StringUtil.StrCmp(A6UmedCod, Z6UmedCod) != 0 )
         {
            A6UmedCod = Z6UmedCod;
            AssignAttri("", false, "A6UmedCod", A6UmedCod);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "UMEDCOD");
            AnyError = 1;
            GX_FocusControl = edtUmedCod_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUmedCod_Internalname;
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
         GetKey025( ) ;
         if ( RcdFound5 == 1 )
         {
            if ( IsIns( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "UMEDCOD");
               AnyError = 1;
               GX_FocusControl = edtUmedCod_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(A6UmedCod, Z6UmedCod) != 0 )
            {
               A6UmedCod = Z6UmedCod;
               AssignAttri("", false, "A6UmedCod", A6UmedCod);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "UMEDCOD");
               AnyError = 1;
               GX_FocusControl = edtUmedCod_Internalname;
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
            if ( StringUtil.StrCmp(A6UmedCod, Z6UmedCod) != 0 )
            {
               Gx_mode = "INS";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               insert_Check( ) ;
            }
            else
            {
               if ( IsUpd( ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "UMEDCOD");
                  AnyError = 1;
                  GX_FocusControl = edtUmedCod_Internalname;
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
         pr_default.close(1);
         pr_default.close(0);
         context.RollbackDataStores("tagumed",pr_default);
         GX_FocusControl = edtUmedDes_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
      }

      protected void insert_Check( )
      {
         CONFIRM_020( ) ;
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
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "UMEDCOD");
            AnyError = 1;
            GX_FocusControl = edtUmedCod_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtUmedDes_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart025( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUmedDes_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd025( ) ;
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
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUmedDes_Internalname;
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
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUmedDes_Internalname;
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
         ScanStart025( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound5 != 0 )
            {
               ScanNext025( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUmedDes_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd025( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency025( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00022 */
            pr_default.execute(0, new Object[] {A6UmedCod});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"agumed"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z19UmedDes, T00022_A19UmedDes[0]) != 0 ) || ( StringUtil.StrCmp(Z31umedabr, T00022_A31umedabr[0]) != 0 ) || ( StringUtil.StrCmp(Z32umedpre, T00022_A32umedpre[0]) != 0 ) || ( StringUtil.StrCmp(Z33umedLKU, T00022_A33umedLKU[0]) != 0 ) || ( StringUtil.StrCmp(Z34umevtasta, T00022_A34umevtasta[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z38UmedDesEti, T00022_A38UmedDesEti[0]) != 0 ) || ( StringUtil.StrCmp(Z35umedusrlog, T00022_A35umedusrlog[0]) != 0 ) || ( Z36umedfeclog != T00022_A36umedfeclog[0] ) || ( StringUtil.StrCmp(Z37umedhralog, T00022_A37umedhralog[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z19UmedDes, T00022_A19UmedDes[0]) != 0 )
               {
                  GXUtil.WriteLog("tagumed:[seudo value changed for attri]"+"UmedDes");
                  GXUtil.WriteLogRaw("Old: ",Z19UmedDes);
                  GXUtil.WriteLogRaw("Current: ",T00022_A19UmedDes[0]);
               }
               if ( StringUtil.StrCmp(Z31umedabr, T00022_A31umedabr[0]) != 0 )
               {
                  GXUtil.WriteLog("tagumed:[seudo value changed for attri]"+"umedabr");
                  GXUtil.WriteLogRaw("Old: ",Z31umedabr);
                  GXUtil.WriteLogRaw("Current: ",T00022_A31umedabr[0]);
               }
               if ( StringUtil.StrCmp(Z32umedpre, T00022_A32umedpre[0]) != 0 )
               {
                  GXUtil.WriteLog("tagumed:[seudo value changed for attri]"+"umedpre");
                  GXUtil.WriteLogRaw("Old: ",Z32umedpre);
                  GXUtil.WriteLogRaw("Current: ",T00022_A32umedpre[0]);
               }
               if ( StringUtil.StrCmp(Z33umedLKU, T00022_A33umedLKU[0]) != 0 )
               {
                  GXUtil.WriteLog("tagumed:[seudo value changed for attri]"+"umedLKU");
                  GXUtil.WriteLogRaw("Old: ",Z33umedLKU);
                  GXUtil.WriteLogRaw("Current: ",T00022_A33umedLKU[0]);
               }
               if ( StringUtil.StrCmp(Z34umevtasta, T00022_A34umevtasta[0]) != 0 )
               {
                  GXUtil.WriteLog("tagumed:[seudo value changed for attri]"+"umevtasta");
                  GXUtil.WriteLogRaw("Old: ",Z34umevtasta);
                  GXUtil.WriteLogRaw("Current: ",T00022_A34umevtasta[0]);
               }
               if ( StringUtil.StrCmp(Z38UmedDesEti, T00022_A38UmedDesEti[0]) != 0 )
               {
                  GXUtil.WriteLog("tagumed:[seudo value changed for attri]"+"UmedDesEti");
                  GXUtil.WriteLogRaw("Old: ",Z38UmedDesEti);
                  GXUtil.WriteLogRaw("Current: ",T00022_A38UmedDesEti[0]);
               }
               if ( StringUtil.StrCmp(Z35umedusrlog, T00022_A35umedusrlog[0]) != 0 )
               {
                  GXUtil.WriteLog("tagumed:[seudo value changed for attri]"+"umedusrlog");
                  GXUtil.WriteLogRaw("Old: ",Z35umedusrlog);
                  GXUtil.WriteLogRaw("Current: ",T00022_A35umedusrlog[0]);
               }
               if ( Z36umedfeclog != T00022_A36umedfeclog[0] )
               {
                  GXUtil.WriteLog("tagumed:[seudo value changed for attri]"+"umedfeclog");
                  GXUtil.WriteLogRaw("Old: ",Z36umedfeclog);
                  GXUtil.WriteLogRaw("Current: ",T00022_A36umedfeclog[0]);
               }
               if ( StringUtil.StrCmp(Z37umedhralog, T00022_A37umedhralog[0]) != 0 )
               {
                  GXUtil.WriteLog("tagumed:[seudo value changed for attri]"+"umedhralog");
                  GXUtil.WriteLogRaw("Old: ",Z37umedhralog);
                  GXUtil.WriteLogRaw("Current: ",T00022_A37umedhralog[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"agumed"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert025( )
      {
         BeforeValidate025( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable025( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM025( 0) ;
            CheckOptimisticConcurrency025( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm025( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert025( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00028 */
                     pr_default.execute(6, new Object[] {A6UmedCod, A19UmedDes, A31umedabr, A32umedpre, A33umedLKU, A34umevtasta, n38UmedDesEti, A38UmedDesEti, A35umedusrlog, A36umedfeclog, A37umedhralog});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("agumed") ;
                     if ( (pr_default.getStatus(6) == 1) )
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
                           endTrnMsgTxt = context.GetMessage( "GXM_sucadded", "");
                           endTrnMsgCod = "SuccessfullyAdded";
                           ResetCaption020( ) ;
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
               Load025( ) ;
            }
            EndLevel025( ) ;
         }
         CloseExtendedTableCursors025( ) ;
      }

      protected void Update025( )
      {
         BeforeValidate025( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable025( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency025( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm025( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate025( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00029 */
                     pr_default.execute(7, new Object[] {A19UmedDes, A31umedabr, A32umedpre, A33umedLKU, A34umevtasta, n38UmedDesEti, A38UmedDesEti, A35umedusrlog, A36umedfeclog, A37umedhralog, A6UmedCod});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("agumed") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"agumed"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate025( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           endTrnMsgTxt = context.GetMessage( "GXM_sucupdated", "");
                           endTrnMsgCod = "SuccessfullyUpdated";
                           ResetCaption020( ) ;
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
            EndLevel025( ) ;
         }
         CloseExtendedTableCursors025( ) ;
      }

      protected void DeferredUpdate025( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate025( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency025( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls025( ) ;
            AfterConfirm025( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete025( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000210 */
                  pr_default.execute(8, new Object[] {A6UmedCod});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("agumed") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound5 == 0 )
                        {
                           InitAll025( ) ;
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
                        ResetCaption020( ) ;
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
         sMode5 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel025( ) ;
         Gx_mode = sMode5;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls025( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            if ( true /* After */ && IsIns( )  )
            {
               GXt_char1 = "UMED";
               GXt_int3 = 5;
               GXt_int2 = 0;
               new pnuevocod(context ).execute( ref  GXt_char1, ref  GXt_int3, ref  A6UmedCod, ref  GXt_int2) ;
               AssignAttri("", false, "A6UmedCod", A6UmedCod);
            }
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000211 */
            pr_default.execute(9, new Object[] {A6UmedCod});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Ambiente General"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel025( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete025( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("tagumed",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues020( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("tagumed",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart025( )
      {
         /* Scan By routine */
         /* Using cursor T000212 */
         pr_default.execute(10);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound5 = 1;
            A6UmedCod = T000212_A6UmedCod[0];
            AssignAttri("", false, "A6UmedCod", A6UmedCod);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext025( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound5 = 1;
            A6UmedCod = T000212_A6UmedCod[0];
            AssignAttri("", false, "A6UmedCod", A6UmedCod);
         }
      }

      protected void ScanEnd025( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm025( )
      {
         /* After Confirm Rules */
         if ( IsIns( )  )
         {
            GXt_char1 = "UMED";
            GXt_int3 = 5;
            GXt_int2 = 1;
            new pnuevocod(context ).execute( ref  GXt_char1, ref  GXt_int3, ref  A6UmedCod, ref  GXt_int2) ;
            AssignAttri("", false, "A6UmedCod", A6UmedCod);
         }
      }

      protected void BeforeInsert025( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate025( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete025( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete025( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate025( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes025( )
      {
         edtUmedCod_Enabled = 0;
         AssignProp("", false, edtUmedCod_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtUmedCod_Enabled), 5, 0), true);
         edtUmedDes_Enabled = 0;
         AssignProp("", false, edtUmedDes_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtUmedDes_Enabled), 5, 0), true);
         edtumedabr_Enabled = 0;
         AssignProp("", false, edtumedabr_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtumedabr_Enabled), 5, 0), true);
         edtumedpre_Enabled = 0;
         AssignProp("", false, edtumedpre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtumedpre_Enabled), 5, 0), true);
         edtumedLKU_Enabled = 0;
         AssignProp("", false, edtumedLKU_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtumedLKU_Enabled), 5, 0), true);
         edtumevtasta_Enabled = 0;
         AssignProp("", false, edtumevtasta_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtumevtasta_Enabled), 5, 0), true);
         edtumedusrlog_Enabled = 0;
         AssignProp("", false, edtumedusrlog_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtumedusrlog_Enabled), 5, 0), true);
         edtumedfeclog_Enabled = 0;
         AssignProp("", false, edtumedfeclog_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtumedfeclog_Enabled), 5, 0), true);
         edtumedhralog_Enabled = 0;
         AssignProp("", false, edtumedhralog_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtumedhralog_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes025( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues020( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, false);
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
         context.AddJavascriptSource("gxcfg.js", "?202242110263096", false, true);
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
         context.WriteHtmlText( " "+"class=\"Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" data-gx-class=\"Form\" novalidate action=\""+formatLink("tagumed.aspx") +"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         AssignProp("", false, "FORM", "Class", "Form", true);
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
         forbiddenHiddens.Add("hshsalt", "hsh"+"Tagumed");
         forbiddenHiddens.Add("UmedDesEti", StringUtil.RTrim( context.localUtil.Format( A38UmedDesEti, "")));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLogInfo("tagumed:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z6UmedCod", StringUtil.RTrim( Z6UmedCod));
         GxWebStd.gx_hidden_field( context, "Z19UmedDes", StringUtil.RTrim( Z19UmedDes));
         GxWebStd.gx_hidden_field( context, "Z31umedabr", StringUtil.RTrim( Z31umedabr));
         GxWebStd.gx_hidden_field( context, "Z32umedpre", StringUtil.RTrim( Z32umedpre));
         GxWebStd.gx_hidden_field( context, "Z33umedLKU", StringUtil.RTrim( Z33umedLKU));
         GxWebStd.gx_hidden_field( context, "Z34umevtasta", StringUtil.RTrim( Z34umevtasta));
         GxWebStd.gx_hidden_field( context, "Z38UmedDesEti", StringUtil.RTrim( Z38UmedDesEti));
         GxWebStd.gx_hidden_field( context, "Z35umedusrlog", StringUtil.RTrim( Z35umedusrlog));
         GxWebStd.gx_hidden_field( context, "Z36umedfeclog", context.localUtil.TToC( Z36umedfeclog, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z37umedhralog", StringUtil.RTrim( Z37umedhralog));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "UMEDDESETI", StringUtil.RTrim( A38UmedDesEti));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV13Pgmname));
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
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "Form" : Form.Class)+"-fx");
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
         return formatLink("tagumed.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Tagumed" ;
      }

      public override String GetPgmdesc( )
      {
         return "Unidades de medida" ;
      }

      protected void InitializeNonKey025( )
      {
         A19UmedDes = "";
         AssignAttri("", false, "A19UmedDes", A19UmedDes);
         A31umedabr = "";
         AssignAttri("", false, "A31umedabr", A31umedabr);
         A32umedpre = "";
         AssignAttri("", false, "A32umedpre", A32umedpre);
         A34umevtasta = "";
         AssignAttri("", false, "A34umevtasta", A34umevtasta);
         A38UmedDesEti = "";
         n38UmedDesEti = false;
         AssignAttri("", false, "A38UmedDesEti", A38UmedDesEti);
         A35umedusrlog = "";
         AssignAttri("", false, "A35umedusrlog", A35umedusrlog);
         A36umedfeclog = (DateTime)(DateTime.MinValue);
         AssignAttri("", false, "A36umedfeclog", context.localUtil.TToC( A36umedfeclog, 10, 8, 0, 3, "/", ":", " "));
         A37umedhralog = "";
         AssignAttri("", false, "A37umedhralog", A37umedhralog);
         A33umedLKU = " ";
         AssignAttri("", false, "A33umedLKU", A33umedLKU);
         Z19UmedDes = "";
         Z31umedabr = "";
         Z32umedpre = "";
         Z33umedLKU = "";
         Z34umevtasta = "";
         Z38UmedDesEti = "";
         Z35umedusrlog = "";
         Z36umedfeclog = (DateTime)(DateTime.MinValue);
         Z37umedhralog = "";
      }

      protected void InitAll025( )
      {
         A6UmedCod = "";
         AssignAttri("", false, "A6UmedCod", A6UmedCod);
         InitializeNonKey025( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A33umedLKU = i33umedLKU;
         AssignAttri("", false, "A33umedLKU", A33umedLKU);
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20224211026313", true, true);
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
         context.AddJavascriptSource("tagumed.js", "?20224211026313", false, true);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         edtUmedCod_Internalname = "UMEDCOD";
         bttBtn_get_Internalname = "BTN_GET";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         edtUmedDes_Internalname = "UMEDDES";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         edtumedabr_Internalname = "UMEDABR";
         lblTextblock4_Internalname = "TEXTBLOCK4";
         edtumedpre_Internalname = "UMEDPRE";
         lblTextblock5_Internalname = "TEXTBLOCK5";
         edtumedLKU_Internalname = "UMEDLKU";
         lblTextblock6_Internalname = "TEXTBLOCK6";
         edtumevtasta_Internalname = "UMEVTASTA";
         lblTextblock7_Internalname = "TEXTBLOCK7";
         edtumedusrlog_Internalname = "UMEDUSRLOG";
         lblTextblock8_Internalname = "TEXTBLOCK8";
         edtumedfeclog_Internalname = "UMEDFECLOG";
         lblTextblock9_Internalname = "TEXTBLOCK9";
         edtumedhralog_Internalname = "UMEDHRALOG";
         tblTable2_Internalname = "TABLE2";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_check_Internalname = "BTN_CHECK";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         bttBtn_help_Internalname = "BTN_HELP";
         tblTable1_Internalname = "TABLE1";
         Form.Internalname = "FORM";
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
         Form.Caption = "Unidades de medida";
         bttBtn_help_Visible = 1;
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_check_Enabled = 1;
         bttBtn_check_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtumedhralog_Jsonclick = "";
         edtumedhralog_Backcolor = (int)(0xFFFFFF);
         edtumedhralog_Enabled = 1;
         edtumedfeclog_Jsonclick = "";
         edtumedfeclog_Backcolor = (int)(0xFFFFFF);
         edtumedfeclog_Enabled = 1;
         edtumedusrlog_Jsonclick = "";
         edtumedusrlog_Backcolor = (int)(0xFFFFFF);
         edtumedusrlog_Enabled = 1;
         edtumevtasta_Jsonclick = "";
         edtumevtasta_Backcolor = (int)(0xFFFFFF);
         edtumevtasta_Enabled = 1;
         edtumedLKU_Jsonclick = "";
         edtumedLKU_Backcolor = (int)(0xFFFFFF);
         edtumedLKU_Enabled = 1;
         edtumedpre_Jsonclick = "";
         edtumedpre_Backcolor = (int)(0xFFFFFF);
         edtumedpre_Enabled = 1;
         edtumedabr_Jsonclick = "";
         edtumedabr_Backcolor = (int)(0xFFFFFF);
         edtumedabr_Enabled = 1;
         edtUmedDes_Jsonclick = "";
         edtUmedDes_Backcolor = (int)(0xFFFFFF);
         edtUmedDes_Enabled = 1;
         bttBtn_get_Enabled = 1;
         bttBtn_get_Visible = 1;
         edtUmedCod_Jsonclick = "";
         edtUmedCod_Backcolor = (int)(0xFFFFFF);
         edtUmedCod_Enabled = 1;
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

      protected void XC_4_025( )
      {
         if ( true /* After */ && IsIns( )  )
         {
            GXt_char1 = "UMED";
            GXt_int3 = 5;
            GXt_int2 = 0;
            new pnuevocod(context ).execute( ref  GXt_char1, ref  GXt_int3, ref  A6UmedCod, ref  GXt_int2) ;
            AssignAttri("", false, "A6UmedCod", A6UmedCod);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "]") ;
         if ( true )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
      }

      protected void XC_5_025( )
      {
         if ( IsIns( )  )
         {
            GXt_char1 = "UMED";
            GXt_int3 = 5;
            GXt_int2 = 1;
            new pnuevocod(context ).execute( ref  GXt_char1, ref  GXt_int3, ref  A6UmedCod, ref  GXt_int2) ;
            AssignAttri("", false, "A6UmedCod", A6UmedCod);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "]") ;
         if ( true )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         GX_FocusControl = edtUmedDes_Internalname;
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

      public void Valid_Umedcod( )
      {
         n38UmedDesEti = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         if ( true /* After */ && IsIns( )  )
         {
            GXt_char1 = "UMED";
            GXt_int3 = 5;
            GXt_int2 = 0;
            new pnuevocod(context ).execute( ref  GXt_char1, ref  GXt_int3, ref  A6UmedCod, ref  GXt_int2) ;
         }
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A19UmedDes", StringUtil.RTrim( A19UmedDes));
         AssignAttri("", false, "A31umedabr", StringUtil.RTrim( A31umedabr));
         AssignAttri("", false, "A32umedpre", StringUtil.RTrim( A32umedpre));
         AssignAttri("", false, "A33umedLKU", StringUtil.RTrim( A33umedLKU));
         AssignAttri("", false, "A34umevtasta", StringUtil.RTrim( A34umevtasta));
         AssignAttri("", false, "A38UmedDesEti", StringUtil.RTrim( A38UmedDesEti));
         AssignAttri("", false, "A35umedusrlog", StringUtil.RTrim( A35umedusrlog));
         AssignAttri("", false, "A36umedfeclog", context.localUtil.TToC( A36umedfeclog, 10, 8, 0, 3, "/", ":", " "));
         AssignAttri("", false, "A37umedhralog", StringUtil.RTrim( A37umedhralog));
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z6UmedCod", StringUtil.RTrim( Z6UmedCod));
         GxWebStd.gx_hidden_field( context, "Z19UmedDes", StringUtil.RTrim( Z19UmedDes));
         GxWebStd.gx_hidden_field( context, "Z31umedabr", StringUtil.RTrim( Z31umedabr));
         GxWebStd.gx_hidden_field( context, "Z32umedpre", StringUtil.RTrim( Z32umedpre));
         GxWebStd.gx_hidden_field( context, "Z33umedLKU", StringUtil.RTrim( Z33umedLKU));
         GxWebStd.gx_hidden_field( context, "Z34umevtasta", StringUtil.RTrim( Z34umevtasta));
         GxWebStd.gx_hidden_field( context, "Z38UmedDesEti", StringUtil.RTrim( Z38UmedDesEti));
         GxWebStd.gx_hidden_field( context, "Z35umedusrlog", StringUtil.RTrim( Z35umedusrlog));
         GxWebStd.gx_hidden_field( context, "Z36umedfeclog", context.localUtil.TToC( Z36umedfeclog, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z37umedhralog", StringUtil.RTrim( Z37umedhralog));
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A38UmedDesEti',fld:'UMEDDESETI',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'IMPRIMIR'","{handler:'E12022',iparms:[]");
         setEventMetadata("'IMPRIMIR'",",oparms:[]}");
         setEventMetadata("VALID_UMEDCOD","{handler:'Valid_Umedcod',iparms:[{av:'A38UmedDesEti',fld:'UMEDDESETI',pic:''},{av:'A6UmedCod',fld:'UMEDCOD',pic:'99999'},{av:'Gx_BScreen',fld:'vGXBSCREEN',pic:'9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'A33umedLKU',fld:'UMEDLKU',pic:''}]");
         setEventMetadata("VALID_UMEDCOD",",oparms:[{av:'A19UmedDes',fld:'UMEDDES',pic:'@!'},{av:'A31umedabr',fld:'UMEDABR',pic:''},{av:'A32umedpre',fld:'UMEDPRE',pic:''},{av:'A33umedLKU',fld:'UMEDLKU',pic:''},{av:'A34umevtasta',fld:'UMEVTASTA',pic:''},{av:'A38UmedDesEti',fld:'UMEDDESETI',pic:''},{av:'A35umedusrlog',fld:'UMEDUSRLOG',pic:''},{av:'A36umedfeclog',fld:'UMEDFECLOG',pic:'99/99/9999 99:99:99'},{av:'A37umedhralog',fld:'UMEDHRALOG',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z6UmedCod'},{av:'Z19UmedDes'},{av:'Z31umedabr'},{av:'Z32umedpre'},{av:'Z33umedLKU'},{av:'Z34umevtasta'},{av:'Z38UmedDesEti'},{av:'Z35umedusrlog'},{av:'Z36umedfeclog'},{av:'Z37umedhralog'},{ctrl:'BTN_GET',prop:'Enabled'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'},{ctrl:'BTN_CHECK',prop:'Enabled'}]}");
         setEventMetadata("VALID_UMEDDES","{handler:'Valid_Umeddes',iparms:[]");
         setEventMetadata("VALID_UMEDDES",",oparms:[]}");
         setEventMetadata("VALID_UMEDFECLOG","{handler:'Valid_Umedfeclog',iparms:[]");
         setEventMetadata("VALID_UMEDFECLOG",",oparms:[]}");
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
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z6UmedCod = "";
         Z19UmedDes = "";
         Z31umedabr = "";
         Z32umedpre = "";
         Z33umedLKU = "";
         Z34umevtasta = "";
         Z38UmedDesEti = "";
         Z35umedusrlog = "";
         Z36umedfeclog = (DateTime)(DateTime.MinValue);
         Z37umedhralog = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         sStyleString = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         lblTextblock1_Jsonclick = "";
         A6UmedCod = "";
         bttBtn_get_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         A19UmedDes = "";
         lblTextblock3_Jsonclick = "";
         A31umedabr = "";
         lblTextblock4_Jsonclick = "";
         A32umedpre = "";
         lblTextblock5_Jsonclick = "";
         A33umedLKU = "";
         lblTextblock6_Jsonclick = "";
         A34umevtasta = "";
         lblTextblock7_Jsonclick = "";
         A35umedusrlog = "";
         lblTextblock8_Jsonclick = "";
         A36umedfeclog = (DateTime)(DateTime.MinValue);
         lblTextblock9_Jsonclick = "";
         A37umedhralog = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_check_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         bttBtn_help_Jsonclick = "";
         A38UmedDesEti = "";
         Gx_mode = "";
         AV13Pgmname = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         endTrnMsgTxt = "";
         endTrnMsgCod = "";
         AV7m_nomtra = "";
         AV8m_staac = "";
         AV11m_opciones = "";
         AV9m_usuacod = "";
         T00024_A6UmedCod = new String[] {""} ;
         T00024_A19UmedDes = new String[] {""} ;
         T00024_A31umedabr = new String[] {""} ;
         T00024_A32umedpre = new String[] {""} ;
         T00024_A33umedLKU = new String[] {""} ;
         T00024_A34umevtasta = new String[] {""} ;
         T00024_A38UmedDesEti = new String[] {""} ;
         T00024_n38UmedDesEti = new bool[] {false} ;
         T00024_A35umedusrlog = new String[] {""} ;
         T00024_A36umedfeclog = new DateTime[] {DateTime.MinValue} ;
         T00024_A37umedhralog = new String[] {""} ;
         T00025_A6UmedCod = new String[] {""} ;
         T00023_A6UmedCod = new String[] {""} ;
         T00023_A19UmedDes = new String[] {""} ;
         T00023_A31umedabr = new String[] {""} ;
         T00023_A32umedpre = new String[] {""} ;
         T00023_A33umedLKU = new String[] {""} ;
         T00023_A34umevtasta = new String[] {""} ;
         T00023_A38UmedDesEti = new String[] {""} ;
         T00023_n38UmedDesEti = new bool[] {false} ;
         T00023_A35umedusrlog = new String[] {""} ;
         T00023_A36umedfeclog = new DateTime[] {DateTime.MinValue} ;
         T00023_A37umedhralog = new String[] {""} ;
         sMode5 = "";
         T00026_A6UmedCod = new String[] {""} ;
         T00027_A6UmedCod = new String[] {""} ;
         T00022_A6UmedCod = new String[] {""} ;
         T00022_A19UmedDes = new String[] {""} ;
         T00022_A31umedabr = new String[] {""} ;
         T00022_A32umedpre = new String[] {""} ;
         T00022_A33umedLKU = new String[] {""} ;
         T00022_A34umevtasta = new String[] {""} ;
         T00022_A38UmedDesEti = new String[] {""} ;
         T00022_n38UmedDesEti = new bool[] {false} ;
         T00022_A35umedusrlog = new String[] {""} ;
         T00022_A36umedfeclog = new DateTime[] {DateTime.MinValue} ;
         T00022_A37umedhralog = new String[] {""} ;
         T000211_A1AmGecod = new String[] {""} ;
         T000212_A6UmedCod = new String[] {""} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         i33umedLKU = "";
         GXt_char1 = "";
         ZZ6UmedCod = "";
         ZZ19UmedDes = "";
         ZZ31umedabr = "";
         ZZ32umedpre = "";
         ZZ33umedLKU = "";
         ZZ34umevtasta = "";
         ZZ38UmedDesEti = "";
         ZZ35umedusrlog = "";
         ZZ36umedfeclog = (DateTime)(DateTime.MinValue);
         ZZ37umedhralog = "";
         pr_sistema = new DataStoreProvider(context, new GeneXus.Programs.tagumed__sistema(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tagumed__default(),
            new Object[][] {
                new Object[] {
               T00022_A6UmedCod, T00022_A19UmedDes, T00022_A31umedabr, T00022_A32umedpre, T00022_A33umedLKU, T00022_A34umevtasta, T00022_A38UmedDesEti, T00022_n38UmedDesEti, T00022_A35umedusrlog, T00022_A36umedfeclog,
               T00022_A37umedhralog
               }
               , new Object[] {
               T00023_A6UmedCod, T00023_A19UmedDes, T00023_A31umedabr, T00023_A32umedpre, T00023_A33umedLKU, T00023_A34umevtasta, T00023_A38UmedDesEti, T00023_n38UmedDesEti, T00023_A35umedusrlog, T00023_A36umedfeclog,
               T00023_A37umedhralog
               }
               , new Object[] {
               T00024_A6UmedCod, T00024_A19UmedDes, T00024_A31umedabr, T00024_A32umedpre, T00024_A33umedLKU, T00024_A34umevtasta, T00024_A38UmedDesEti, T00024_n38UmedDesEti, T00024_A35umedusrlog, T00024_A36umedfeclog,
               T00024_A37umedhralog
               }
               , new Object[] {
               T00025_A6UmedCod
               }
               , new Object[] {
               T00026_A6UmedCod
               }
               , new Object[] {
               T00027_A6UmedCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000211_A1AmGecod
               }
               , new Object[] {
               T000212_A6UmedCod
               }
            }
         );
         AV13Pgmname = "Tagumed";
         Z33umedLKU = " ";
         A33umedLKU = " ";
         i33umedLKU = " ";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Gx_BScreen ;
      private short GX_JID ;
      private short RcdFound5 ;
      private short nIsDirty_5 ;
      private short gxajaxcallmode ;
      private short GXt_int3 ;
      private short GXt_int2 ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUmedCod_Enabled ;
      private int bttBtn_get_Visible ;
      private int bttBtn_get_Enabled ;
      private int edtUmedDes_Enabled ;
      private int edtumedabr_Enabled ;
      private int edtumedpre_Enabled ;
      private int edtumedLKU_Enabled ;
      private int edtumevtasta_Enabled ;
      private int edtumedusrlog_Enabled ;
      private int edtumedfeclog_Enabled ;
      private int edtumedhralog_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_check_Visible ;
      private int bttBtn_check_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int bttBtn_help_Visible ;
      private int idxLst ;
      private int edtumedhralog_Backcolor ;
      private int edtumedfeclog_Backcolor ;
      private int edtumedusrlog_Backcolor ;
      private int edtumevtasta_Backcolor ;
      private int edtumedLKU_Backcolor ;
      private int edtumedpre_Backcolor ;
      private int edtumedabr_Backcolor ;
      private int edtUmedDes_Backcolor ;
      private int edtUmedCod_Backcolor ;
      private String sPrefix ;
      private String Z6UmedCod ;
      private String Z19UmedDes ;
      private String Z31umedabr ;
      private String Z32umedpre ;
      private String Z33umedLKU ;
      private String Z34umevtasta ;
      private String Z38UmedDesEti ;
      private String Z35umedusrlog ;
      private String Z37umedhralog ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUmedCod_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
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
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String A6UmedCod ;
      private String edtUmedCod_Jsonclick ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtUmedDes_Internalname ;
      private String A19UmedDes ;
      private String edtUmedDes_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtumedabr_Internalname ;
      private String A31umedabr ;
      private String edtumedabr_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtumedpre_Internalname ;
      private String A32umedpre ;
      private String edtumedpre_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtumedLKU_Internalname ;
      private String A33umedLKU ;
      private String edtumedLKU_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtumevtasta_Internalname ;
      private String A34umevtasta ;
      private String edtumevtasta_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtumedusrlog_Internalname ;
      private String A35umedusrlog ;
      private String edtumedusrlog_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String edtumedfeclog_Internalname ;
      private String edtumedfeclog_Jsonclick ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String edtumedhralog_Internalname ;
      private String A37umedhralog ;
      private String edtumedhralog_Jsonclick ;
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
      private String A38UmedDesEti ;
      private String Gx_mode ;
      private String AV13Pgmname ;
      private String hsh ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String endTrnMsgTxt ;
      private String endTrnMsgCod ;
      private String AV7m_nomtra ;
      private String AV8m_staac ;
      private String AV11m_opciones ;
      private String AV9m_usuacod ;
      private String sMode5 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String i33umedLKU ;
      private String GXt_char1 ;
      private String ZZ6UmedCod ;
      private String ZZ19UmedDes ;
      private String ZZ31umedabr ;
      private String ZZ32umedpre ;
      private String ZZ33umedLKU ;
      private String ZZ34umevtasta ;
      private String ZZ38UmedDesEti ;
      private String ZZ35umedusrlog ;
      private String ZZ37umedhralog ;
      private DateTime Z36umedfeclog ;
      private DateTime A36umedfeclog ;
      private DateTime ZZ36umedfeclog ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n38UmedDesEti ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private GXProperties forbiddenHiddens ;
      private IGxDataStore dsSistema ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00024_A6UmedCod ;
      private String[] T00024_A19UmedDes ;
      private String[] T00024_A31umedabr ;
      private String[] T00024_A32umedpre ;
      private String[] T00024_A33umedLKU ;
      private String[] T00024_A34umevtasta ;
      private String[] T00024_A38UmedDesEti ;
      private bool[] T00024_n38UmedDesEti ;
      private String[] T00024_A35umedusrlog ;
      private DateTime[] T00024_A36umedfeclog ;
      private String[] T00024_A37umedhralog ;
      private String[] T00025_A6UmedCod ;
      private String[] T00023_A6UmedCod ;
      private String[] T00023_A19UmedDes ;
      private String[] T00023_A31umedabr ;
      private String[] T00023_A32umedpre ;
      private String[] T00023_A33umedLKU ;
      private String[] T00023_A34umevtasta ;
      private String[] T00023_A38UmedDesEti ;
      private bool[] T00023_n38UmedDesEti ;
      private String[] T00023_A35umedusrlog ;
      private DateTime[] T00023_A36umedfeclog ;
      private String[] T00023_A37umedhralog ;
      private String[] T00026_A6UmedCod ;
      private String[] T00027_A6UmedCod ;
      private String[] T00022_A6UmedCod ;
      private String[] T00022_A19UmedDes ;
      private String[] T00022_A31umedabr ;
      private String[] T00022_A32umedpre ;
      private String[] T00022_A33umedLKU ;
      private String[] T00022_A34umevtasta ;
      private String[] T00022_A38UmedDesEti ;
      private bool[] T00022_n38UmedDesEti ;
      private String[] T00022_A35umedusrlog ;
      private DateTime[] T00022_A36umedfeclog ;
      private String[] T00022_A37umedhralog ;
      private String[] T000211_A1AmGecod ;
      private String[] T000212_A6UmedCod ;
      private IDataStoreProvider pr_sistema ;
      private GXWebForm Form ;
   }

   public class tagumed__sistema : DataStoreHelperBase, IDataStoreHelper
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

 public class tagumed__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new UpdateCursor(def[6])
       ,new UpdateCursor(def[7])
       ,new UpdateCursor(def[8])
       ,new ForEachCursor(def[9])
       ,new ForEachCursor(def[10])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00024 ;
        prmT00024 = new Object[] {
        new Object[] {"@UmedCod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT00025 ;
        prmT00025 = new Object[] {
        new Object[] {"@UmedCod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT00023 ;
        prmT00023 = new Object[] {
        new Object[] {"@UmedCod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT00026 ;
        prmT00026 = new Object[] {
        new Object[] {"@UmedCod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT00027 ;
        prmT00027 = new Object[] {
        new Object[] {"@UmedCod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT00022 ;
        prmT00022 = new Object[] {
        new Object[] {"@UmedCod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT00028 ;
        prmT00028 = new Object[] {
        new Object[] {"@UmedCod",SqlDbType.NChar,5,0} ,
        new Object[] {"@UmedDes",SqlDbType.NChar,15,0} ,
        new Object[] {"@umedabr",SqlDbType.NChar,3,0} ,
        new Object[] {"@umedpre",SqlDbType.NChar,15,0} ,
        new Object[] {"@umedLKU",SqlDbType.NChar,1,0} ,
        new Object[] {"@umevtasta",SqlDbType.NChar,1,0} ,
        new Object[] {"@UmedDesEti",SqlDbType.NChar,3,0} ,
        new Object[] {"@umedusrlog",SqlDbType.NChar,5,0} ,
        new Object[] {"@umedfeclog",SqlDbType.DateTime,10,8} ,
        new Object[] {"@umedhralog",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT00029 ;
        prmT00029 = new Object[] {
        new Object[] {"@UmedDes",SqlDbType.NChar,15,0} ,
        new Object[] {"@umedabr",SqlDbType.NChar,3,0} ,
        new Object[] {"@umedpre",SqlDbType.NChar,15,0} ,
        new Object[] {"@umedLKU",SqlDbType.NChar,1,0} ,
        new Object[] {"@umevtasta",SqlDbType.NChar,1,0} ,
        new Object[] {"@UmedDesEti",SqlDbType.NChar,3,0} ,
        new Object[] {"@umedusrlog",SqlDbType.NChar,5,0} ,
        new Object[] {"@umedfeclog",SqlDbType.DateTime,10,8} ,
        new Object[] {"@umedhralog",SqlDbType.NChar,5,0} ,
        new Object[] {"@UmedCod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000210 ;
        prmT000210 = new Object[] {
        new Object[] {"@UmedCod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000211 ;
        prmT000211 = new Object[] {
        new Object[] {"@UmedCod",SqlDbType.NChar,5,0}
        } ;
        Object[] prmT000212 ;
        prmT000212 = new Object[] {
        } ;
        def= new CursorDef[] {
            new CursorDef("T00022", "SELECT [UmedCod], [UmedDes], [umedabr], [umedpre], [umedLKU], [umevtasta], [UmedDesEti], [umedusrlog], [umedfeclog], [umedhralog] FROM [agumed] WITH (UPDLOCK) WHERE [UmedCod] = @UmedCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00023", "SELECT [UmedCod], [UmedDes], [umedabr], [umedpre], [umedLKU], [umevtasta], [UmedDesEti], [umedusrlog], [umedfeclog], [umedhralog] FROM [agumed] WHERE [UmedCod] = @UmedCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00024", "SELECT TM1.[UmedCod], TM1.[UmedDes], TM1.[umedabr], TM1.[umedpre], TM1.[umedLKU], TM1.[umevtasta], TM1.[UmedDesEti], TM1.[umedusrlog], TM1.[umedfeclog], TM1.[umedhralog] FROM [agumed] TM1 WHERE TM1.[UmedCod] = @UmedCod ORDER BY TM1.[UmedCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,100, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00025", "SELECT [UmedCod] FROM [agumed] WHERE [UmedCod] = @UmedCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,1, GxCacheFrequency.OFF ,true,false )
           ,new CursorDef("T00026", "SELECT TOP 1 [UmedCod] FROM [agumed] WHERE ( [UmedCod] > @UmedCod) ORDER BY [UmedCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00026,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T00027", "SELECT TOP 1 [UmedCod] FROM [agumed] WHERE ( [UmedCod] < @UmedCod) ORDER BY [UmedCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T00028", "INSERT INTO [agumed]([UmedCod], [UmedDes], [umedabr], [umedpre], [umedLKU], [umevtasta], [UmedDesEti], [umedusrlog], [umedfeclog], [umedhralog]) VALUES(@UmedCod, @UmedDes, @umedabr, @umedpre, @umedLKU, @umevtasta, @UmedDesEti, @umedusrlog, @umedfeclog, @umedhralog)", GxErrorMask.GX_NOMASK,prmT00028)
           ,new CursorDef("T00029", "UPDATE [agumed] SET [UmedDes]=@UmedDes, [umedabr]=@umedabr, [umedpre]=@umedpre, [umedLKU]=@umedLKU, [umevtasta]=@umevtasta, [UmedDesEti]=@UmedDesEti, [umedusrlog]=@umedusrlog, [umedfeclog]=@umedfeclog, [umedhralog]=@umedhralog  WHERE [UmedCod] = @UmedCod", GxErrorMask.GX_NOMASK,prmT00029)
           ,new CursorDef("T000210", "DELETE FROM [agumed]  WHERE [UmedCod] = @UmedCod", GxErrorMask.GX_NOMASK,prmT000210)
           ,new CursorDef("T000211", "SELECT TOP 1 [AmGecod] FROM [agAmGe] WHERE [AmgeUmedCd] = @UmedCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000211,1, GxCacheFrequency.OFF ,true,true )
           ,new CursorDef("T000212", "SELECT [UmedCod] FROM [agumed] ORDER BY [UmedCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000212,100, GxCacheFrequency.OFF ,true,false )
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
              ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
              ((String[]) buf[2])[0] = rslt.getString(3, 3) ;
              ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
              ((String[]) buf[4])[0] = rslt.getString(5, 1) ;
              ((String[]) buf[5])[0] = rslt.getString(6, 1) ;
              ((String[]) buf[6])[0] = rslt.getString(7, 3) ;
              ((bool[]) buf[7])[0] = rslt.wasNull(7);
              ((String[]) buf[8])[0] = rslt.getString(8, 5) ;
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(9) ;
              ((String[]) buf[10])[0] = rslt.getString(10, 5) ;
              return;
           case 1 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
              ((String[]) buf[2])[0] = rslt.getString(3, 3) ;
              ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
              ((String[]) buf[4])[0] = rslt.getString(5, 1) ;
              ((String[]) buf[5])[0] = rslt.getString(6, 1) ;
              ((String[]) buf[6])[0] = rslt.getString(7, 3) ;
              ((bool[]) buf[7])[0] = rslt.wasNull(7);
              ((String[]) buf[8])[0] = rslt.getString(8, 5) ;
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(9) ;
              ((String[]) buf[10])[0] = rslt.getString(10, 5) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
              ((String[]) buf[2])[0] = rslt.getString(3, 3) ;
              ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
              ((String[]) buf[4])[0] = rslt.getString(5, 1) ;
              ((String[]) buf[5])[0] = rslt.getString(6, 1) ;
              ((String[]) buf[6])[0] = rslt.getString(7, 3) ;
              ((bool[]) buf[7])[0] = rslt.wasNull(7);
              ((String[]) buf[8])[0] = rslt.getString(8, 5) ;
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(9) ;
              ((String[]) buf[10])[0] = rslt.getString(10, 5) ;
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              return;
           case 5 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              return;
           case 9 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
              return;
           case 10 :
              ((String[]) buf[0])[0] = rslt.getString(1, 5) ;
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
              return;
           case 1 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 2 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (String)parms[4]);
              stmt.SetParameter(6, (String)parms[5]);
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 7 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[7]);
              }
              stmt.SetParameter(8, (String)parms[8]);
              stmt.SetParameterDatetime(9, (DateTime)parms[9]);
              stmt.SetParameter(10, (String)parms[10]);
              return;
           case 7 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (String)parms[4]);
              if ( (bool)parms[5] )
              {
                 stmt.setNull( 6 , SqlDbType.NChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[6]);
              }
              stmt.SetParameter(7, (String)parms[7]);
              stmt.SetParameterDatetime(8, (DateTime)parms[8]);
              stmt.SetParameter(9, (String)parms[9]);
              stmt.SetParameter(10, (String)parms[10]);
              return;
           case 8 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
     }
  }

}

}
