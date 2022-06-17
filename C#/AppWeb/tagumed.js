/*!   GeneXus C# 16_0_11-144151 on 4/21/2022 10:26:31.51
*/
gx.evt.autoSkip=!1;gx.define("tagumed",!1,function(){this.ServerClass="tagumed";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_BScreen=gx.fn.getIntegerValue("vGXBSCREEN",".");this.A38UmedDesEti=gx.fn.getControlValue("UMEDDESETI");this.AV13Pgmname=gx.fn.getControlValue("vPGMNAME")};this.Valid_Umedcod=function(){return this.validSrvEvt("Valid_Umedcod",0).then(function(n){return n}.closure(this))};this.Valid_Umeddes=function(){return this.validCliEvt("Valid_Umeddes",0,function(){try{var n=gx.util.balloon.getNew("UMEDDES");if(this.AnyError=0,""==this.A19UmedDes)try{n.setError("Ingrese nombre");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Umedfeclog=function(){return this.validCliEvt("Valid_Umedfeclog",0,function(){try{var n=gx.util.balloon.getNew("UMEDFECLOG");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A36umedfeclog)==0||new gx.date.gxdate(this.A36umedfeclog).compare(gx.date.ymdhmstot(1753,1,1,0,0,0))>=0))try{n.setError("Campo umedfeclog fuera de rango");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e13025_client=function(){return this.clearMessages(),this.addMessage("Para insertar un nuevo registro, ingrese un código en blanco"),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e14025_client=function(){return this.clearMessages(),this.addMessage("Para editar un registro, digite el Código "),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e12022_client=function(){return this.executeServerEvent("'IMPRIMIR'",!0,null,!1,!1)};this.e15025_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e16025_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,5,6,7,8,9,15,18,20,21,24,26,29,31,34,36,39,41,44,46,49,51,54,56,59,61,64,65,66,67,68];this.GXLastCtrlId=68;n[2]={id:2,fld:"TABLE1",grid:0};n[5]={id:5,fld:"BTN_FIRST",grid:0,evt:"e17025_client",std:"FIRST"};n[6]={id:6,fld:"BTN_PREVIOUS",grid:0,evt:"e18025_client",std:"PREVIOUS"};n[7]={id:7,fld:"BTN_NEXT",grid:0,evt:"e19025_client",std:"NEXT"};n[8]={id:8,fld:"BTN_LAST",grid:0,evt:"e20025_client",std:"LAST"};n[9]={id:9,fld:"BTN_SELECT",grid:0,evt:"e21025_client",std:"SELECT"};n[15]={id:15,fld:"TABLE2",grid:0};n[18]={id:18,fld:"TEXTBLOCK1",format:0,grid:0};n[20]={id:20,lvl:0,type:"char",len:5,dec:0,sign:!1,pic:"99999",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Umedcod,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"UMEDCOD",gxz:"Z6UmedCod",gxold:"O6UmedCod",gxvar:"A6UmedCod",ucs:[],op:[61,56,51,46,41,36,31,26],ip:[61,56,51,46,41,36,31,26,20],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A6UmedCod=n)},v2z:function(n){n!==undefined&&(gx.O.Z6UmedCod=n)},v2c:function(){gx.fn.setControlValue("UMEDCOD",gx.O.A6UmedCod,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A6UmedCod=this.val())},val:function(){return gx.fn.getControlValue("UMEDCOD")},nac:gx.falseFn};this.declareDomainHdlr(20,function(){});n[21]={id:21,fld:"BTN_GET",grid:0,evt:"e22025_client",std:"GET"};n[24]={id:24,fld:"TEXTBLOCK2",format:0,grid:0};n[26]={id:26,lvl:0,type:"char",len:15,dec:0,sign:!1,pic:"@!",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Umeddes,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"UMEDDES",gxz:"Z19UmedDes",gxold:"O19UmedDes",gxvar:"A19UmedDes",ucs:[],op:[26],ip:[26],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A19UmedDes=n)},v2z:function(n){n!==undefined&&(gx.O.Z19UmedDes=n)},v2c:function(){gx.fn.setControlValue("UMEDDES",gx.O.A19UmedDes,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A19UmedDes=this.val())},val:function(){return gx.fn.getControlValue("UMEDDES")},nac:gx.falseFn};this.declareDomainHdlr(26,function(){});n[29]={id:29,fld:"TEXTBLOCK3",format:0,grid:0};n[31]={id:31,lvl:0,type:"char",len:3,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"UMEDABR",gxz:"Z31umedabr",gxold:"O31umedabr",gxvar:"A31umedabr",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A31umedabr=n)},v2z:function(n){n!==undefined&&(gx.O.Z31umedabr=n)},v2c:function(){gx.fn.setControlValue("UMEDABR",gx.O.A31umedabr,0)},c2v:function(){this.val()!==undefined&&(gx.O.A31umedabr=this.val())},val:function(){return gx.fn.getControlValue("UMEDABR")},nac:gx.falseFn};n[34]={id:34,fld:"TEXTBLOCK4",format:0,grid:0};n[36]={id:36,lvl:0,type:"char",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"UMEDPRE",gxz:"Z32umedpre",gxold:"O32umedpre",gxvar:"A32umedpre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A32umedpre=n)},v2z:function(n){n!==undefined&&(gx.O.Z32umedpre=n)},v2c:function(){gx.fn.setControlValue("UMEDPRE",gx.O.A32umedpre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A32umedpre=this.val())},val:function(){return gx.fn.getControlValue("UMEDPRE")},nac:gx.falseFn};n[39]={id:39,fld:"TEXTBLOCK5",format:0,grid:0};n[41]={id:41,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"UMEDLKU",gxz:"Z33umedLKU",gxold:"O33umedLKU",gxvar:"A33umedLKU",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A33umedLKU=n)},v2z:function(n){n!==undefined&&(gx.O.Z33umedLKU=n)},v2c:function(){gx.fn.setControlValue("UMEDLKU",gx.O.A33umedLKU,0)},c2v:function(){this.val()!==undefined&&(gx.O.A33umedLKU=this.val())},val:function(){return gx.fn.getControlValue("UMEDLKU")},nac:gx.falseFn};n[44]={id:44,fld:"TEXTBLOCK6",format:0,grid:0};n[46]={id:46,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"UMEVTASTA",gxz:"Z34umevtasta",gxold:"O34umevtasta",gxvar:"A34umevtasta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A34umevtasta=n)},v2z:function(n){n!==undefined&&(gx.O.Z34umevtasta=n)},v2c:function(){gx.fn.setControlValue("UMEVTASTA",gx.O.A34umevtasta,0)},c2v:function(){this.val()!==undefined&&(gx.O.A34umevtasta=this.val())},val:function(){return gx.fn.getControlValue("UMEVTASTA")},nac:gx.falseFn};n[49]={id:49,fld:"TEXTBLOCK7",format:0,grid:0};n[51]={id:51,lvl:0,type:"char",len:5,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"UMEDUSRLOG",gxz:"Z35umedusrlog",gxold:"O35umedusrlog",gxvar:"A35umedusrlog",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A35umedusrlog=n)},v2z:function(n){n!==undefined&&(gx.O.Z35umedusrlog=n)},v2c:function(){gx.fn.setControlValue("UMEDUSRLOG",gx.O.A35umedusrlog,0)},c2v:function(){this.val()!==undefined&&(gx.O.A35umedusrlog=this.val())},val:function(){return gx.fn.getControlValue("UMEDUSRLOG")},nac:gx.falseFn};n[54]={id:54,fld:"TEXTBLOCK8",format:0,grid:0};n[56]={id:56,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Umedfeclog,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"UMEDFECLOG",gxz:"Z36umedfeclog",gxold:"O36umedfeclog",gxvar:"A36umedfeclog",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[56],ip:[56],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A36umedfeclog=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z36umedfeclog=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("UMEDFECLOG",gx.O.A36umedfeclog,0)},c2v:function(){this.val()!==undefined&&(gx.O.A36umedfeclog=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("UMEDFECLOG")},nac:gx.falseFn};n[59]={id:59,fld:"TEXTBLOCK9",format:0,grid:0};n[61]={id:61,lvl:0,type:"char",len:5,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"UMEDHRALOG",gxz:"Z37umedhralog",gxold:"O37umedhralog",gxvar:"A37umedhralog",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A37umedhralog=n)},v2z:function(n){n!==undefined&&(gx.O.Z37umedhralog=n)},v2c:function(){gx.fn.setControlValue("UMEDHRALOG",gx.O.A37umedhralog,0)},c2v:function(){this.val()!==undefined&&(gx.O.A37umedhralog=this.val())},val:function(){return gx.fn.getControlValue("UMEDHRALOG")},nac:gx.falseFn};n[64]={id:64,fld:"BTN_ENTER",grid:0,evt:"e15025_client",std:"ENTER"};n[65]={id:65,fld:"BTN_CHECK",grid:0,evt:"e23025_client",std:"CHECK"};n[66]={id:66,fld:"BTN_CANCEL",grid:0,evt:"e16025_client"};n[67]={id:67,fld:"BTN_DELETE",grid:0,evt:"e24025_client",std:"DELETE"};n[68]={id:68,fld:"BTN_HELP",grid:0,evt:"e25025_client"};this.A6UmedCod="";this.Z6UmedCod="";this.O6UmedCod="";this.A19UmedDes="";this.Z19UmedDes="";this.O19UmedDes="";this.A31umedabr="";this.Z31umedabr="";this.O31umedabr="";this.A32umedpre="";this.Z32umedpre="";this.O32umedpre="";this.A33umedLKU="";this.Z33umedLKU="";this.O33umedLKU="";this.A34umevtasta="";this.Z34umevtasta="";this.O34umevtasta="";this.A35umedusrlog="";this.Z35umedusrlog="";this.O35umedusrlog="";this.A36umedfeclog=gx.date.nullDate();this.Z36umedfeclog=gx.date.nullDate();this.O36umedfeclog=gx.date.nullDate();this.A37umedhralog="";this.Z37umedhralog="";this.O37umedhralog="";this.AV7m_nomtra="";this.AV8m_staac="";this.AV11m_opciones="";this.AV9m_usuacod="";this.A6UmedCod="";this.AV13Pgmname="";this.Gx_BScreen=0;this.A19UmedDes="";this.A31umedabr="";this.A32umedpre="";this.A33umedLKU="";this.A34umevtasta="";this.A38UmedDesEti="";this.A35umedusrlog="";this.A36umedfeclog=gx.date.nullDate();this.A37umedhralog="";this.Events={e12022_client:["'IMPRIMIR'",!0],e15025_client:["ENTER",!0],e16025_client:["CANCEL",!0],e13025_client:["'NUEVO'",!1],e14025_client:["'EDITAR'",!1]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[{av:"A38UmedDesEti",fld:"UMEDDESETI",pic:""}],[]];this.EvtParms["'IMPRIMIR'"]=[[],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8m_staac",fld:"vM_STAAC",pic:""},{av:"AV11m_opciones",fld:"vM_OPCIONES",pic:""},{av:"AV9m_usuacod",fld:"vM_USUACOD",pic:""}],[{av:"AV7m_nomtra",fld:"vM_NOMTRA",pic:"@!"},{av:"AV9m_usuacod",fld:"vM_USUACOD",pic:""},{av:"AV11m_opciones",fld:"vM_OPCIONES",pic:""},{av:"AV8m_staac",fld:"vM_STAAC",pic:""}]];this.EvtParms["'NUEVO'"]=[[],[]];this.EvtParms["'EDITAR'"]=[[],[]];this.EvtParms.VALID_UMEDCOD=[[{av:"A38UmedDesEti",fld:"UMEDDESETI",pic:""},{av:"A6UmedCod",fld:"UMEDCOD",pic:"99999"},{av:"Gx_BScreen",fld:"vGXBSCREEN",pic:"9"},{av:"Gx_mode",fld:"vMODE",pic:"@!"},{av:"A33umedLKU",fld:"UMEDLKU",pic:""}],[{av:"A19UmedDes",fld:"UMEDDES",pic:"@!"},{av:"A31umedabr",fld:"UMEDABR",pic:""},{av:"A32umedpre",fld:"UMEDPRE",pic:""},{av:"A33umedLKU",fld:"UMEDLKU",pic:""},{av:"A34umevtasta",fld:"UMEVTASTA",pic:""},{av:"A38UmedDesEti",fld:"UMEDDESETI",pic:""},{av:"A35umedusrlog",fld:"UMEDUSRLOG",pic:""},{av:"A36umedfeclog",fld:"UMEDFECLOG",pic:"99/99/9999 99:99:99"},{av:"A37umedhralog",fld:"UMEDHRALOG",pic:""},{av:"Gx_mode",fld:"vMODE",pic:"@!"},{av:"Z6UmedCod"},{av:"Z19UmedDes"},{av:"Z31umedabr"},{av:"Z32umedpre"},{av:"Z33umedLKU"},{av:"Z34umevtasta"},{av:"Z38UmedDesEti"},{av:"Z35umedusrlog"},{av:"Z36umedfeclog"},{av:"Z37umedhralog"},{ctrl:"BTN_GET",prop:"Enabled"},{ctrl:"BTN_DELETE",prop:"Enabled"},{ctrl:"BTN_ENTER",prop:"Enabled"},{ctrl:"BTN_CHECK",prop:"Enabled"}]];this.EvtParms.VALID_UMEDDES=[[{av:"A19UmedDes",fld:"UMEDDES",pic:"@!"}],[{av:"A19UmedDes",fld:"UMEDDES",pic:"@!"}]];this.EvtParms.VALID_UMEDFECLOG=[[{av:"A36umedfeclog",fld:"UMEDFECLOG",pic:"99/99/9999 99:99:99"}],[{av:"A36umedfeclog",fld:"UMEDFECLOG",pic:"99/99/9999 99:99:99"}]];this.EnterCtrl=["BTN_ENTER"];this.CheckCtrl=["BTN_CHECK"];this.setVCMap("Gx_BScreen","vGXBSCREEN",0,"int",1,0);this.setVCMap("A38UmedDesEti","UMEDDESETI",0,"char",3,0);this.setVCMap("AV13Pgmname","vPGMNAME",0,"char",129,0);this.Initialize()});gx.wi(function(){gx.createParentObj(tagumed)})