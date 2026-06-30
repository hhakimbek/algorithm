import 'dart:io';

void main() {
  print("KABISA");
  stdout.write("Year: ");
  String yearStr = stdin.readLineSync()??'';
  int year = int.parse(yearStr);
  if(year%400==0) {
    print(366);
  } else {
    if(year%4==0 && year%100!=0) {
      print(366);
    } else {
      print(365);
    }
  }
}