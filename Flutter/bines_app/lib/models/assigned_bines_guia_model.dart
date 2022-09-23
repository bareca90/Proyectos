// To parse this JSON data, do
//
//     final binesGuiaAssigned = binesGuiaAssignedFromJson(jsonString);

import 'dart:convert';

BinesGuiaAssigned binesGuiaAssignedFromJson(String str) =>
    BinesGuiaAssigned.fromJson(json.decode(str));

String binesGuiaAssignedToJson(BinesGuiaAssigned data) =>
    json.encode(data.toJson());

class BinesGuiaAssigned {
  BinesGuiaAssigned({
    required this.tipoproceso,
    required this.nroguia,
    required this.kg,
    required this.piscina,
    required this.fechaguia,
    required this.cantescaneada,
    required this.nrobin,
    required this.fechahoraesc,
    required this.sincronizado,
  });

  String tipoproceso;
  String nroguia;
  double kg;
  String piscina;
  String fechaguia;
  int cantescaneada;
  int nrobin;
  String fechahoraesc;
  int sincronizado;

  factory BinesGuiaAssigned.fromJson(Map<String, dynamic> json) =>
      BinesGuiaAssigned(
        tipoproceso: json["tipoproceso"],
        nroguia: json["nroguia"],
        kg: json["kg"].toDouble(),
        piscina: json["piscina"],
        fechaguia: json["fechaguia"],
        cantescaneada: json["cantescaneada"],
        nrobin: json["nrobin"],
        fechahoraesc: json["fechahoraesc"],
        sincronizado: json["sincronizado"],
      );

  Map<String, dynamic> toJson() => {
        "tipoproceso": tipoproceso,
        "nroguia": nroguia,
        "kg": kg,
        "piscina": piscina,
        "fechaguia": fechaguia,
        "cantescaneada": cantescaneada,
        "nrobin": nrobin,
        "fechahoraesc": fechahoraesc,
        "sincronizado": sincronizado,
      };
}
