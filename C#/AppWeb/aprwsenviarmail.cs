/*
               File: PrWsEnviarMail
        Description: Ws que permitira enviar los correos
             Author: GeneXus C# Generator version 16_0_11-144151
       Generated on: 4/21/2022 10:26:31.82
       Program type: Main program
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Mail;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class aprwsenviarmail : GXProcedure
   {
      public aprwsenviarmail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsSistema = context.GetDataStore("Sistema");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public aprwsenviarmail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsSistema = context.GetDataStore("Sistema");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Subject ,
                           String aP1_Html ,
                           GXBaseCollection<SdtSdWsDireccionesMail_SdWsDireccionesMailItem> aP2_SdWsDireccionesMail ,
                           GXBaseCollection<SdtSdWsCopiasMail_SdWsCopiasMailItem> aP3_SdWsCopiasMail ,
                           GXBaseCollection<SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem> aP4_SdWsCopiaOcultaMail ,
                           GXBaseCollection<SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem> aP5_SdWsAdjuntosMail ,
                           out GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem> aP6_SdWsEnviarMail )
      {
         this.AV28Subject = aP0_Subject;
         this.AV29Html = aP1_Html;
         this.AV30SdWsDireccionesMail = aP2_SdWsDireccionesMail;
         this.AV32SdWsCopiasMail = aP3_SdWsCopiasMail;
         this.AV34SdWsCopiaOcultaMail = aP4_SdWsCopiaOcultaMail;
         this.AV36SdWsAdjuntosMail = aP5_SdWsAdjuntosMail;
         this.AV9SdWsEnviarMail = new GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem>( context, "SdWsEnviarMailItem", "KbAppsWeb") ;
         initialize();
         executePrivate();
         aP6_SdWsEnviarMail=this.AV9SdWsEnviarMail;
      }

      public GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem> executeUdp( String aP0_Subject ,
                                                                                String aP1_Html ,
                                                                                GXBaseCollection<SdtSdWsDireccionesMail_SdWsDireccionesMailItem> aP2_SdWsDireccionesMail ,
                                                                                GXBaseCollection<SdtSdWsCopiasMail_SdWsCopiasMailItem> aP3_SdWsCopiasMail ,
                                                                                GXBaseCollection<SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem> aP4_SdWsCopiaOcultaMail ,
                                                                                GXBaseCollection<SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem> aP5_SdWsAdjuntosMail )
      {
         execute(aP0_Subject, aP1_Html, aP2_SdWsDireccionesMail, aP3_SdWsCopiasMail, aP4_SdWsCopiaOcultaMail, aP5_SdWsAdjuntosMail, out aP6_SdWsEnviarMail);
         return AV9SdWsEnviarMail ;
      }

      public void executeSubmit( String aP0_Subject ,
                                 String aP1_Html ,
                                 GXBaseCollection<SdtSdWsDireccionesMail_SdWsDireccionesMailItem> aP2_SdWsDireccionesMail ,
                                 GXBaseCollection<SdtSdWsCopiasMail_SdWsCopiasMailItem> aP3_SdWsCopiasMail ,
                                 GXBaseCollection<SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem> aP4_SdWsCopiaOcultaMail ,
                                 GXBaseCollection<SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem> aP5_SdWsAdjuntosMail ,
                                 out GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem> aP6_SdWsEnviarMail )
      {
         aprwsenviarmail objaprwsenviarmail;
         objaprwsenviarmail = new aprwsenviarmail();
         objaprwsenviarmail.AV28Subject = aP0_Subject;
         objaprwsenviarmail.AV29Html = aP1_Html;
         objaprwsenviarmail.AV30SdWsDireccionesMail = aP2_SdWsDireccionesMail;
         objaprwsenviarmail.AV32SdWsCopiasMail = aP3_SdWsCopiasMail;
         objaprwsenviarmail.AV34SdWsCopiaOcultaMail = aP4_SdWsCopiaOcultaMail;
         objaprwsenviarmail.AV36SdWsAdjuntosMail = aP5_SdWsAdjuntosMail;
         objaprwsenviarmail.AV9SdWsEnviarMail = new GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem>( context, "SdWsEnviarMailItem", "KbAppsWeb") ;
         objaprwsenviarmail.context.SetSubmitInitialConfig(context);
         objaprwsenviarmail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objaprwsenviarmail);
         aP6_SdWsEnviarMail=this.AV9SdWsEnviarMail;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((aprwsenviarmail)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /* User Code */
          System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls;
         AV23mensaje = "";
         AV24tipo = "";
         AV27envio.Subject = AV28Subject;
         AV27envio.HTMLText = AV29Html;
         AV38mail_envio = new GeneXus.Mail.GXMailRecipient();
         AV39mail_copia = new GeneXus.Mail.GXMailRecipient();
         AV40mail_copia_oculta = new GeneXus.Mail.GXMailRecipient();
         if ( AV30SdWsDireccionesMail.Count > 0 )
         {
            AV43GXV1 = 1;
            while ( AV43GXV1 <= AV30SdWsDireccionesMail.Count )
            {
               AV31SdWsDireccionesMailItems = ((SdtSdWsDireccionesMail_SdWsDireccionesMailItem)AV30SdWsDireccionesMail.Item(AV43GXV1));
               AV38mail_envio.Address = AV31SdWsDireccionesMailItems.gxTpr_Address;
               AV27envio.To.Add(AV38mail_envio);
               AV43GXV1 = (int)(AV43GXV1+1);
            }
         }
         else
         {
            AV24tipo = "Error";
            AV23mensaje = "No Existe Direccion para Enviar Mail";
            /* Execute user subroutine: 'MENSAJE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            this.cleanup();
            if (true) return;
         }
         if ( AV32SdWsCopiasMail.Count > 0 )
         {
            AV44GXV2 = 1;
            while ( AV44GXV2 <= AV32SdWsCopiasMail.Count )
            {
               AV33SdWsCopiasMailItems = ((SdtSdWsCopiasMail_SdWsCopiasMailItem)AV32SdWsCopiasMail.Item(AV44GXV2));
               AV39mail_copia.Address = AV33SdWsCopiasMailItems.gxTpr_Cc;
               AV27envio.CC.Add(AV39mail_copia);
               AV44GXV2 = (int)(AV44GXV2+1);
            }
         }
         if ( AV34SdWsCopiaOcultaMail.Count > 0 )
         {
            AV45GXV3 = 1;
            while ( AV45GXV3 <= AV34SdWsCopiaOcultaMail.Count )
            {
               AV35SdWsCopiaOcultaMailItems = ((SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem)AV34SdWsCopiaOcultaMail.Item(AV45GXV3));
               AV40mail_copia_oculta.Address = AV35SdWsCopiaOcultaMailItems.gxTpr_Bcc;
               AV27envio.BCC.Add(AV40mail_copia_oculta);
               AV45GXV3 = (int)(AV45GXV3+1);
            }
         }
         if ( AV36SdWsAdjuntosMail.Count > 0 )
         {
            AV46GXV4 = 1;
            while ( AV46GXV4 <= AV36SdWsAdjuntosMail.Count )
            {
               AV37SdWsAdjuntosMailItems = ((SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem)AV36SdWsAdjuntosMail.Item(AV46GXV4));
               AV27envio.Attachments.Add(AV37SdWsAdjuntosMailItems.gxTpr_Attachments);
               AV46GXV4 = (int)(AV46GXV4+1);
            }
         }
         AV47GXLvl46 = 0;
         /* Using cursor P000D2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1AmGecod = P000D2_A1AmGecod[0];
            A8AmGesta = P000D2_A8AmGesta[0];
            n8AmGesta = P000D2_n8AmGesta[0];
            A51AmgeMailEstado = P000D2_A51AmgeMailEstado[0];
            A44AmGeMailPort = P000D2_A44AmGeMailPort[0];
            A45AmGeMailHost = P000D2_A45AmGeMailHost[0];
            A46AmGeMailSender = P000D2_A46AmGeMailSender[0];
            A47AmgeMailUser = P000D2_A47AmgeMailUser[0];
            A48AmgeMailPassword = P000D2_A48AmgeMailPassword[0];
            A49AmgeMailAuthentication = P000D2_A49AmgeMailAuthentication[0];
            A50AmgeMailSecure = P000D2_A50AmgeMailSecure[0];
            A43AmGeMailSec = P000D2_A43AmGeMailSec[0];
            A8AmGesta = P000D2_A8AmGesta[0];
            n8AmGesta = P000D2_n8AmGesta[0];
            AV47GXLvl46 = 1;
            AV15AmGeMailPort = A44AmGeMailPort;
            AV16AmGeMailHost = A45AmGeMailHost;
            AV17AmGeMailSender = A46AmGeMailSender;
            AV18AmgeMailUser = A47AmgeMailUser;
            AV19AmgeMailPassword = A48AmgeMailPassword;
            AV20AmgeMailAuthentication = A49AmgeMailAuthentication;
            AV21AmgeMailSecure = A50AmgeMailSecure;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV47GXLvl46 == 0 )
         {
            AV9SdWsEnviarMail.Clear();
            AV13SdWsEnviarMailItems = new SdtSdWsEnviarMail_SdWsEnviarMailItem(context);
            AV13SdWsEnviarMailItems.gxTpr_Msj = "Error";
            AV13SdWsEnviarMailItems.gxTpr_Respuesta = "No se Encuentra Registrado Datos del SMTP o no se encuentra Activo";
            AV9SdWsEnviarMail.Add(AV13SdWsEnviarMailItems, 0);
         }
         AV23mensaje = "";
         AV24tipo = "";
         if ( ( AV15AmGeMailPort == 0 ) || (0==AV15AmGeMailPort) )
         {
            AV24tipo = "Error";
            AV23mensaje = "No Se Encuentra Registrado el puerto, favor Revisar !!";
            /* Execute user subroutine: 'MENSAJE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            this.cleanup();
            if (true) return;
         }
         if ( ( StringUtil.StrCmp(AV16AmGeMailHost, "") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( AV16AmGeMailHost)) )
         {
            AV24tipo = "Error";
            AV23mensaje = "No Se Encuentra Registrado Host, favor Revisar !!";
            /* Execute user subroutine: 'MENSAJE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            this.cleanup();
            if (true) return;
         }
         if ( ( StringUtil.StrCmp(AV17AmGeMailSender, "") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( AV17AmGeMailSender)) )
         {
            AV24tipo = "Error";
            AV23mensaje = "No Se Encuentra Registrado Usuario SMTP, favor Revisar !!";
            /* Execute user subroutine: 'MENSAJE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            this.cleanup();
            if (true) return;
         }
         if ( ( StringUtil.StrCmp(AV19AmgeMailPassword, "") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( AV19AmgeMailPassword)) )
         {
            AV24tipo = "Error";
            AV23mensaje = "No Se Encuentra Registrado clave, favor Revisar !!";
            /* Execute user subroutine: 'MENSAJE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            this.cleanup();
            if (true) return;
         }
         AV25MensSMTP.Host = AV16AmGeMailHost;
         AV25MensSMTP.Sender.Address = AV17AmGeMailSender;
         AV25MensSMTP.Sender.Name = "Notificación SIPE";
         AV25MensSMTP.UserName = AV18AmgeMailUser;
         AV25MensSMTP.Password = StringUtil.Trim( AV19AmgeMailPassword);
         AV25MensSMTP.Port = AV15AmGeMailPort;
         AV25MensSMTP.Authentication = 1;
         AV25MensSMTP.Secure = 1;
         AV26errrcode = AV25MensSMTP.ErrCode;
         if ( ( AV26errrcode == 0 ) || ( AV26errrcode == 1 ) )
         {
            AV25MensSMTP.Login();
            AV25MensSMTP.Send(AV27envio);
            AV25MensSMTP.Logout();
            AV24tipo = "Correcto";
            AV23mensaje = "Mail Enviado Satisfactoriamente !!";
            /* Execute user subroutine: 'MENSAJE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else
         {
            AV24tipo = "Incorrecto";
            AV23mensaje = "El envio del mail fallo, el número de error es" + StringUtil.Trim( StringUtil.Str( (decimal)(AV26errrcode), 10, 0));
            /* Execute user subroutine: 'MENSAJE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'MENSAJE' Routine */
         AV9SdWsEnviarMail.Clear();
         AV13SdWsEnviarMailItems = new SdtSdWsEnviarMail_SdWsEnviarMailItem(context);
         AV13SdWsEnviarMailItems.gxTpr_Msj = AV24tipo;
         AV13SdWsEnviarMailItems.gxTpr_Respuesta = AV23mensaje;
         AV9SdWsEnviarMail.Add(AV13SdWsEnviarMailItems, 0);
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV23mensaje = "";
         AV24tipo = "";
         AV27envio = new GeneXus.Mail.GXMailMessage();
         AV38mail_envio = new GeneXus.Mail.GXMailRecipient();
         AV39mail_copia = new GeneXus.Mail.GXMailRecipient();
         AV40mail_copia_oculta = new GeneXus.Mail.GXMailRecipient();
         AV31SdWsDireccionesMailItems = new SdtSdWsDireccionesMail_SdWsDireccionesMailItem(context);
         AV33SdWsCopiasMailItems = new SdtSdWsCopiasMail_SdWsCopiasMailItem(context);
         AV35SdWsCopiaOcultaMailItems = new SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem(context);
         AV37SdWsAdjuntosMailItems = new SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem(context);
         scmdbuf = "";
         P000D2_A1AmGecod = new String[] {""} ;
         P000D2_A8AmGesta = new String[] {""} ;
         P000D2_n8AmGesta = new bool[] {false} ;
         P000D2_A51AmgeMailEstado = new String[] {""} ;
         P000D2_A44AmGeMailPort = new short[1] ;
         P000D2_A45AmGeMailHost = new String[] {""} ;
         P000D2_A46AmGeMailSender = new String[] {""} ;
         P000D2_A47AmgeMailUser = new String[] {""} ;
         P000D2_A48AmgeMailPassword = new String[] {""} ;
         P000D2_A49AmgeMailAuthentication = new bool[] {false} ;
         P000D2_A50AmgeMailSecure = new bool[] {false} ;
         P000D2_A43AmGeMailSec = new String[] {""} ;
         A1AmGecod = "";
         A8AmGesta = "";
         A51AmgeMailEstado = "";
         A45AmGeMailHost = "";
         A46AmGeMailSender = "";
         A47AmgeMailUser = "";
         A48AmgeMailPassword = "";
         A43AmGeMailSec = "";
         AV16AmGeMailHost = "";
         AV17AmGeMailSender = "";
         AV18AmgeMailUser = "";
         AV19AmgeMailPassword = "";
         AV13SdWsEnviarMailItems = new SdtSdWsEnviarMail_SdWsEnviarMailItem(context);
         AV25MensSMTP = new GeneXus.Mail.GXSMTPSession(context.GetPhysicalPath());
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aprwsenviarmail__default(),
            new Object[][] {
                new Object[] {
               P000D2_A1AmGecod, P000D2_A8AmGesta, P000D2_n8AmGesta, P000D2_A51AmgeMailEstado, P000D2_A44AmGeMailPort, P000D2_A45AmGeMailHost, P000D2_A46AmGeMailSender, P000D2_A47AmgeMailUser, P000D2_A48AmgeMailPassword, P000D2_A49AmgeMailAuthentication,
               P000D2_A50AmgeMailSecure, P000D2_A43AmGeMailSec
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV47GXLvl46 ;
      private short A44AmGeMailPort ;
      private short AV15AmGeMailPort ;
      private short AV26errrcode ;
      private int AV43GXV1 ;
      private int AV44GXV2 ;
      private int AV45GXV3 ;
      private int AV46GXV4 ;
      private String AV24tipo ;
      private String scmdbuf ;
      private String A1AmGecod ;
      private String A8AmGesta ;
      private String A51AmgeMailEstado ;
      private String A43AmGeMailSec ;
      private bool returnInSub ;
      private bool n8AmGesta ;
      private bool A49AmgeMailAuthentication ;
      private bool A50AmgeMailSecure ;
      private bool AV20AmgeMailAuthentication ;
      private bool AV21AmgeMailSecure ;
      private String AV29Html ;
      private String AV28Subject ;
      private String AV23mensaje ;
      private String A45AmGeMailHost ;
      private String A46AmGeMailSender ;
      private String A47AmgeMailUser ;
      private String A48AmgeMailPassword ;
      private String AV16AmGeMailHost ;
      private String AV17AmGeMailSender ;
      private String AV18AmgeMailUser ;
      private String AV19AmgeMailPassword ;
      private IGxDataStore dsSistema ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000D2_A1AmGecod ;
      private String[] P000D2_A8AmGesta ;
      private bool[] P000D2_n8AmGesta ;
      private String[] P000D2_A51AmgeMailEstado ;
      private short[] P000D2_A44AmGeMailPort ;
      private String[] P000D2_A45AmGeMailHost ;
      private String[] P000D2_A46AmGeMailSender ;
      private String[] P000D2_A47AmgeMailUser ;
      private String[] P000D2_A48AmgeMailPassword ;
      private bool[] P000D2_A49AmgeMailAuthentication ;
      private bool[] P000D2_A50AmgeMailSecure ;
      private String[] P000D2_A43AmGeMailSec ;
      private GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem> aP6_SdWsEnviarMail ;
      private GeneXus.Mail.GXMailMessage AV27envio ;
      private GeneXus.Mail.GXMailRecipient AV38mail_envio ;
      private GeneXus.Mail.GXMailRecipient AV39mail_copia ;
      private GeneXus.Mail.GXMailRecipient AV40mail_copia_oculta ;
      private GeneXus.Mail.GXSMTPSession AV25MensSMTP ;
      private GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem> AV9SdWsEnviarMail ;
      private GXBaseCollection<SdtSdWsDireccionesMail_SdWsDireccionesMailItem> AV30SdWsDireccionesMail ;
      private GXBaseCollection<SdtSdWsCopiasMail_SdWsCopiasMailItem> AV32SdWsCopiasMail ;
      private GXBaseCollection<SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem> AV34SdWsCopiaOcultaMail ;
      private GXBaseCollection<SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem> AV36SdWsAdjuntosMail ;
      private SdtSdWsEnviarMail_SdWsEnviarMailItem AV13SdWsEnviarMailItems ;
      private SdtSdWsDireccionesMail_SdWsDireccionesMailItem AV31SdWsDireccionesMailItems ;
      private SdtSdWsCopiasMail_SdWsCopiasMailItem AV33SdWsCopiasMailItems ;
      private SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem AV35SdWsCopiaOcultaMailItems ;
      private SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem AV37SdWsAdjuntosMailItems ;
   }

   public class aprwsenviarmail__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000D2 ;
          prmP000D2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000D2", "SELECT T1.[AmGecod], T2.[AmGesta], T1.[AmgeMailEstado], T1.[AmGeMailPort], T1.[AmGeMailHost], T1.[AmGeMailSender], T1.[AmgeMailUser], T1.[AmgeMailPassword], T1.[AmgeMailAuthentication], T1.[AmgeMailSecure], T1.[AmGeMailSec] FROM ([AgAmGe4] T1 INNER JOIN [agAmGe] T2 ON T2.[AmGecod] = T1.[AmGecod]) WHERE (T1.[AmgeMailEstado] = 'A') AND (T2.[AmGesta] = 'O') ORDER BY T1.[AmGecod], T1.[AmGeMailSec] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000D2,100, GxCacheFrequency.OFF ,false,false )
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
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[9])[0] = rslt.getBool(9) ;
                ((bool[]) buf[10])[0] = rslt.getBool(10) ;
                ((String[]) buf[11])[0] = rslt.getString(11, 2) ;
                return;
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

 }

 [ServiceContract(Namespace = "GeneXus.Programs.prwsenviarmail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class prwsenviarmail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String Subject ,
                         String Html ,
                         GxGenericCollection<SdtSdWsDireccionesMail_SdWsDireccionesMailItem_RESTInterface> SdWsDireccionesMail ,
                         GxGenericCollection<SdtSdWsCopiasMail_SdWsCopiasMailItem_RESTInterface> SdWsCopiasMail ,
                         GxGenericCollection<SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem_RESTInterface> SdWsCopiaOcultaMail ,
                         GxGenericCollection<SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem_RESTInterface> SdWsAdjuntosMail ,
                         out GxGenericCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem_RESTInterface> SdWsEnviarMail )
    {
       SdWsEnviarMail = new GxGenericCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("prwsenviarmail") )
          {
             return  ;
          }
          aprwsenviarmail worker = new aprwsenviarmail(context) ;
          worker.IsMain = RunAsMain ;
          GXBaseCollection<SdtSdWsDireccionesMail_SdWsDireccionesMailItem> gxrSdWsDireccionesMail = new GXBaseCollection<SdtSdWsDireccionesMail_SdWsDireccionesMailItem>() ;
          SdWsDireccionesMail.LoadCollection(gxrSdWsDireccionesMail);
          GXBaseCollection<SdtSdWsCopiasMail_SdWsCopiasMailItem> gxrSdWsCopiasMail = new GXBaseCollection<SdtSdWsCopiasMail_SdWsCopiasMailItem>() ;
          SdWsCopiasMail.LoadCollection(gxrSdWsCopiasMail);
          GXBaseCollection<SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem> gxrSdWsCopiaOcultaMail = new GXBaseCollection<SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem>() ;
          SdWsCopiaOcultaMail.LoadCollection(gxrSdWsCopiaOcultaMail);
          GXBaseCollection<SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem> gxrSdWsAdjuntosMail = new GXBaseCollection<SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem>() ;
          SdWsAdjuntosMail.LoadCollection(gxrSdWsAdjuntosMail);
          GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem> gxrSdWsEnviarMail = new GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem>() ;
          worker.execute(Subject,Html,gxrSdWsDireccionesMail,gxrSdWsCopiasMail,gxrSdWsCopiaOcultaMail,gxrSdWsAdjuntosMail,out gxrSdWsEnviarMail );
          worker.cleanup( );
          SdWsEnviarMail = new GxGenericCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem_RESTInterface>(gxrSdWsEnviarMail) ;
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
    }

 }

}
