/*
				   File: type_SdtSdWsDireccionesMail_SdWsDireccionesMailItem
			Description: SdWsDireccionesMail
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
	[XmlRoot(ElementName="SdWsDireccionesMailItem")]
	[XmlType(TypeName="SdWsDireccionesMailItem" , Namespace="KbAppsWeb" )]
	[Serializable]
	public class SdtSdWsDireccionesMail_SdWsDireccionesMailItem : GxUserType
	{
		public SdtSdWsDireccionesMail_SdWsDireccionesMailItem( )
		{
			/* Constructor for serialization */
			gxTv_SdtSdWsDireccionesMail_SdWsDireccionesMailItem_Address = "";

		}

		public SdtSdWsDireccionesMail_SdWsDireccionesMailItem(IGxContext context)
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
			AddObjectProperty("Address", gxTpr_Address, false);

			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Address")]
		[XmlElement(ElementName="Address")]
		public String gxTpr_Address
		{
			get { 
				return gxTv_SdtSdWsDireccionesMail_SdWsDireccionesMailItem_Address; 
			}
			set { 
				gxTv_SdtSdWsDireccionesMail_SdWsDireccionesMailItem_Address = value;
				SetDirty("Address");
			}
		}




		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSdWsDireccionesMail_SdWsDireccionesMailItem_Address = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSdWsDireccionesMail_SdWsDireccionesMailItem_Address;
		 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SdWsDireccionesMailItem", Namespace="KbAppsWeb")]
	public class SdtSdWsDireccionesMail_SdWsDireccionesMailItem_RESTInterface : GxGenericCollectionItem<SdtSdWsDireccionesMail_SdWsDireccionesMailItem>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSdWsDireccionesMail_SdWsDireccionesMailItem_RESTInterface( ) : base()
		{
		}

		public SdtSdWsDireccionesMail_SdWsDireccionesMailItem_RESTInterface( SdtSdWsDireccionesMail_SdWsDireccionesMailItem psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Address", Order=0)]
		public  String gxTpr_Address
		{
			get { 
				return sdt.gxTpr_Address;

			}
			set { 
				 sdt.gxTpr_Address = value;
			}
		}


		#endregion

		public SdtSdWsDireccionesMail_SdWsDireccionesMailItem sdt
		{
			get { 
				return (SdtSdWsDireccionesMail_SdWsDireccionesMailItem)Sdt;
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
				sdt = new SdtSdWsDireccionesMail_SdWsDireccionesMailItem() ;
			}
		}
	}
	#endregion
}