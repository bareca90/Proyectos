/*
				   File: type_SdtSdWsCopiasMail_SdWsCopiasMailItem
			Description: SdWsCopiasMail
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
	[XmlRoot(ElementName="SdWsCopiasMailItem")]
	[XmlType(TypeName="SdWsCopiasMailItem" , Namespace="KbAppsWeb" )]
	[Serializable]
	public class SdtSdWsCopiasMail_SdWsCopiasMailItem : GxUserType
	{
		public SdtSdWsCopiasMail_SdWsCopiasMailItem( )
		{
			/* Constructor for serialization */
			gxTv_SdtSdWsCopiasMail_SdWsCopiasMailItem_Cc = "";

		}

		public SdtSdWsCopiasMail_SdWsCopiasMailItem(IGxContext context)
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
			AddObjectProperty("CC", gxTpr_Cc, false);

			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="CC")]
		[XmlElement(ElementName="CC")]
		public String gxTpr_Cc
		{
			get { 
				return gxTv_SdtSdWsCopiasMail_SdWsCopiasMailItem_Cc; 
			}
			set { 
				gxTv_SdtSdWsCopiasMail_SdWsCopiasMailItem_Cc = value;
				SetDirty("Cc");
			}
		}




		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSdWsCopiasMail_SdWsCopiasMailItem_Cc = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSdWsCopiasMail_SdWsCopiasMailItem_Cc;
		 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SdWsCopiasMailItem", Namespace="KbAppsWeb")]
	public class SdtSdWsCopiasMail_SdWsCopiasMailItem_RESTInterface : GxGenericCollectionItem<SdtSdWsCopiasMail_SdWsCopiasMailItem>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSdWsCopiasMail_SdWsCopiasMailItem_RESTInterface( ) : base()
		{
		}

		public SdtSdWsCopiasMail_SdWsCopiasMailItem_RESTInterface( SdtSdWsCopiasMail_SdWsCopiasMailItem psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="CC", Order=0)]
		public  String gxTpr_Cc
		{
			get { 
				return sdt.gxTpr_Cc;

			}
			set { 
				 sdt.gxTpr_Cc = value;
			}
		}


		#endregion

		public SdtSdWsCopiasMail_SdWsCopiasMailItem sdt
		{
			get { 
				return (SdtSdWsCopiasMail_SdWsCopiasMailItem)Sdt;
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
				sdt = new SdtSdWsCopiasMail_SdWsCopiasMailItem() ;
			}
		}
	}
	#endregion
}