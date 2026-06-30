import 'dart:io';
import 'dart:math';

void main() {
  stdout.write("a = ");
  String aStr = stdin.readLineSync()??'';
  stdout.write("b = ");
  String bStr = stdin.readLineSync()??'';
  stdout.write("c = ");
  String cStr = stdin.readLineSync()??'';

  int a = int.tryParse(aStr)??0;
  int b = int.tryParse(bStr)??0;
  int c = int.tryParse(cStr)??0;

  int minimumV1 = a;
  if(minimumV1>b)minimumV1=b;
  if(minimumV1>c)minimumV1=c;
  print("Minimum V1: ${minimumV1}");

  int minimumV2 = min(a, min(b,c));
  print("Minimum V2: ${minimumV2}");
}