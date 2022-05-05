/*
				   File: type_SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem
			Description: SdWsCopiaOcultaMail
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
	[XmlRoot(ElementName="SdWsCopiaOcultaMailItem")]
	[XmlType(TypeName="SdWsCopiaOcultaMailItem" , Namespace="KbAppsWeb" )]
	[Serializable]
	public class SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem : GxUserType
	{
		public SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem( )
		{
			/* Constructor for serialization */
			gxTv_SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem_Bcc = "";

		}

		public SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem(IGxContext context)
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
			AddObjectProperty("BCC", gxTpr_Bcc, false);

			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="BCC")]
		[XmlElement(ElementName="BCC")]
		public String gxTpr_Bcc
		{
			get { 
				return gxTv_SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem_Bcc; 
			}
			set { 
				gxTv_SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem_Bcc = value;
				SetDirty("Bcc");
			}
		}




		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem_Bcc = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem_Bcc;
		 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SdWsCopiaOcultaMailItem", Namespace="KbAppsWeb")]
	public class SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem_RESTInterface : GxGenericCollectionItem<SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem_RESTInterface( ) : base()
		{
		}

		public SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem_RESTInterface( SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="BCC", Order=0)]
		public  String gxTpr_Bcc
		{
			get { 
				return sdt.gxTpr_Bcc;

			}
			set { 
				 sdt.gxTpr_Bcc = value;
			}
		}


		#endregion

		public SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem sdt
		{
			get { 
				return (SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem)Sdt;
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
				sdt = new SdtSdWsCopiaOcultaMail_SdWsCopiaOcultaMailItem() ;
			}
		}
	}
	#endregion
}