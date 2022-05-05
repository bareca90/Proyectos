/*
				   File: type_SdtSdWsEnviarMail
			Description: SdWsEnviarMail
				 Author: Nemo 🐠 for C# version 16.0.11.144151
		   Program type: Callable routine
			  Main DBMS: 
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Reflection;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web.Services.Protocols;


namespace GeneXus.Programs
{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="SdWsEnviarMail")]
	[XmlType(TypeName="SdWsEnviarMail" , Namespace="KbAppsWeb" )]
	[Serializable]
	public class SdtSdWsEnviarMail : GxUserType
	{
		public SdtSdWsEnviarMail( )
		{
			/* Constructor for serialization */
			gxTv_SdtSdWsEnviarMail_Msj = "";

			gxTv_SdtSdWsEnviarMail_Respuesta = "";

		}

		public SdtSdWsEnviarMail(IGxContext context)
		{
			this.context = context;
			initialize();
		}

		#region Json
		private static Hashtable mapper;
		public override String JsonMap(String value)
		{
			if (mapper == null)
			{
				mapper = new Hashtable();
			}
			return (String)mapper[value]; ;
		}

		public override void ToJSON()
		{
			ToJSON(true) ;
			return;
		}

		public override void ToJSON(bool includeState)
		{
			AddObjectProperty("Msj", gxTpr_Msj, false);


			AddObjectProperty("Respuesta", gxTpr_Respuesta, false);

			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Msj")]
		[XmlElement(ElementName="Msj")]
		public String gxTpr_Msj
		{
			get { 
				return gxTv_SdtSdWsEnviarMail_Msj; 
			}
			set { 
				gxTv_SdtSdWsEnviarMail_Msj = value;
				SetDirty("Msj");
			}
		}




		[SoapElement(ElementName="Respuesta")]
		[XmlElement(ElementName="Respuesta")]
		public String gxTpr_Respuesta
		{
			get { 
				return gxTv_SdtSdWsEnviarMail_Respuesta; 
			}
			set { 
				gxTv_SdtSdWsEnviarMail_Respuesta = value;
				SetDirty("Respuesta");
			}
		}




		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSdWsEnviarMail_Msj = "";
			gxTv_SdtSdWsEnviarMail_Respuesta = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSdWsEnviarMail_Msj;
		 

		protected String gxTv_SdtSdWsEnviarMail_Respuesta;
		 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SdWsEnviarMail", Namespace="KbAppsWeb")]
	public class SdtSdWsEnviarMail_RESTInterface : GxGenericCollectionItem<SdtSdWsEnviarMail>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSdWsEnviarMail_RESTInterface( ) : base()
		{
		}

		public SdtSdWsEnviarMail_RESTInterface( SdtSdWsEnviarMail psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Msj", Order=0)]
		public  String gxTpr_Msj
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Msj);

			}
			set { 
				 sdt.gxTpr_Msj = value;
			}
		}

		[DataMember(Name="Respuesta", Order=1)]
		public  String gxTpr_Respuesta
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Respuesta);

			}
			set { 
				 sdt.gxTpr_Respuesta = value;
			}
		}


		#endregion

		public SdtSdWsEnviarMail sdt
		{
			get { 
				return (SdtSdWsEnviarMail)Sdt;
			}
			set { 
				Sdt = value;
			}
		}

		[OnDeserializing]
		void checkSdt( StreamingContext ctx )
		{
			if ( sdt == null )
			{
				sdt = new SdtSdWsEnviarMail() ;
			}
		}
	}
	#endregion
}