/*
               File: PrWsEnviarMail
        Description: Stub for PrWsEnviarMail
             Author: GeneXus C# Generator version 16_0_11-144151
       Generated on: 4/21/2022 10:26:31.71
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
using System.Web.Services.Protocols;
using System.Web.Services;
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
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class prwsenviarmail : GXProcedure
   {
      public prwsenviarmail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsSistema = context.GetDataStore("Sistema");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public prwsenviarmail( IGxContext context )
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
         this.AV2Subject = aP0_Subject;
         this.AV3Html = aP1_Html;
         this.AV4SdWsDireccionesMail = aP2_SdWsDireccionesMail;
         this.AV5SdWsCopiasMail = aP3_SdWsCopiasMail;
         this.AV6SdWsCopiaOcultaMail = aP4_SdWsCopiaOcultaMail;
         this.AV7SdWsAdjuntosMail = aP5_SdWsAdjuntosMail;
         this.AV8SdWsEnviarMail = new GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem>( context, "SdWsEnviarMailItem", "KbAppsWeb") ;
         initialize();
         executePrivate();
         aP6_SdWsEnviarMail=this.AV8SdWsEnviarMail;
      }

      public GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem> executeUdp( String aP0_Subject ,
                                                                                String aP1_Html ,
                                                                                GXBaseCollection<SdtSdWsDireccionesMail_SdWsDireccionesMailItem> aP2_SdWsDireccionesMail ,
                                                                                GXBaseCollection<SdtSdWsCopiasMail_SdWsCopiasMailItem> aP3_SdWsCopiasMail ,
                                                                                GXBaseCollection<SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem> aP4_SdWsCopiaOcultaMail ,
                                                                                GXBaseCollection<SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem> aP5_SdWsAdjuntosMail )
      {
         execute(aP0_Subject, aP1_Html, aP2_SdWsDireccionesMail, aP3_SdWsCopiasMail, aP4_SdWsCopiaOcultaMail, aP5_SdWsAdjuntosMail, out aP6_SdWsEnviarMail);
         return AV8SdWsEnviarMail ;
      }

      public void executeSubmit( String aP0_Subject ,
                                 String aP1_Html ,
                                 GXBaseCollection<SdtSdWsDireccionesMail_SdWsDireccionesMailItem> aP2_SdWsDireccionesMail ,
                                 GXBaseCollection<SdtSdWsCopiasMail_SdWsCopiasMailItem> aP3_SdWsCopiasMail ,
                                 GXBaseCollection<SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem> aP4_SdWsCopiaOcultaMail ,
                                 GXBaseCollection<SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem> aP5_SdWsAdjuntosMail ,
                                 out GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem> aP6_SdWsEnviarMail )
      {
         prwsenviarmail objprwsenviarmail;
         objprwsenviarmail = new prwsenviarmail();
         objprwsenviarmail.AV2Subject = aP0_Subject;
         objprwsenviarmail.AV3Html = aP1_Html;
         objprwsenviarmail.AV4SdWsDireccionesMail = aP2_SdWsDireccionesMail;
         objprwsenviarmail.AV5SdWsCopiasMail = aP3_SdWsCopiasMail;
         objprwsenviarmail.AV6SdWsCopiaOcultaMail = aP4_SdWsCopiaOcultaMail;
         objprwsenviarmail.AV7SdWsAdjuntosMail = aP5_SdWsAdjuntosMail;
         objprwsenviarmail.AV8SdWsEnviarMail = new GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem>( context, "SdWsEnviarMailItem", "KbAppsWeb") ;
         objprwsenviarmail.context.SetSubmitInitialConfig(context);
         objprwsenviarmail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprwsenviarmail);
         aP6_SdWsEnviarMail=this.AV8SdWsEnviarMail;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((prwsenviarmail)stateInfo).executePrivate();
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
         args = new Object[] {(String)AV2Subject,(String)AV3Html,(GXBaseCollection<SdtSdWsDireccionesMail_SdWsDireccionesMailItem>)AV4SdWsDireccionesMail,(GXBaseCollection<SdtSdWsCopiasMail_SdWsCopiasMailItem>)AV5SdWsCopiasMail,(GXBaseCollection<SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem>)AV6SdWsCopiaOcultaMail,(GXBaseCollection<SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem>)AV7SdWsAdjuntosMail,(GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem>)AV8SdWsEnviarMail} ;
         ClassLoader.Execute("aprwsenviarmail","GeneXus.Programs","aprwsenviarmail", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 7 ) )
         {
            AV8SdWsEnviarMail = (GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem>)(args[6]) ;
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
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
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV3Html ;
      private String AV2Subject ;
      private IGxDataStore dsSistema ;
      private IGxDataStore dsDefault ;
      private Object[] args ;
      private GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem> aP6_SdWsEnviarMail ;
      private GXBaseCollection<SdtSdWsEnviarMail_SdWsEnviarMailItem> AV8SdWsEnviarMail ;
      private GXBaseCollection<SdtSdWsDireccionesMail_SdWsDireccionesMailItem> AV4SdWsDireccionesMail ;
      private GXBaseCollection<SdtSdWsCopiasMail_SdWsCopiasMailItem> AV5SdWsCopiasMail ;
      private GXBaseCollection<SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem> AV6SdWsCopiaOcultaMail ;
      private GXBaseCollection<SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem> AV7SdWsAdjuntosMail ;
   }

}
