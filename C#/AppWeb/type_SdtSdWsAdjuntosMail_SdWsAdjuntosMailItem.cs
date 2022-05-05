/*
				   File: type_SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem
			Description: SdWsAdjuntosMail
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
	[XmlRoot(ElementName="SdWsAdjuntosMailItem")]
	[XmlType(TypeName="SdWsAdjuntosMailItem" , Namespace="KbAppsWeb" )]
	[Serializable]
	public class SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem : GxUserType
	{
		public SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem( )
		{
			/* Constructor for serialization */
			gxTv_SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem_Attachments = "";

		}

		public SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem(IGxContext context)
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
			AddObjectProperty("Attachments", gxTpr_Attachments, false);

			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Attachments")]
		[XmlElement(ElementName="Attachments")]
		public String gxTpr_Attachments
		{
			get { 
				return gxTv_SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem_Attachments; 
			}
			set { 
				gxTv_SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem_Attachments = value;
				SetDirty("Attachments");
			}
		}




		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem_Attachments = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem_Attachments;
		 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SdWsAdjuntosMailItem", Namespace="KbAppsWeb")]
	public class SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem_RESTInterface : GxGenericCollectionItem<SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem_RESTInterface( ) : base()
		{
		}

		public SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem_RESTInterface( SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Attachments", Order=0)]
		public  String gxTpr_Attachments
		{
			get { 
				return sdt.gxTpr_Attachments;

			}
			set { 
				 sdt.gxTpr_Attachments = value;
			}
		}


		#endregion

		public SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem sdt
		{
			get { 
				return (SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem)Sdt;
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
				sdt = new SdtSdWsAdjuntosMail_SdWsAdjuntosMailItem() ;
			}
		}
	}
	#endregion
}