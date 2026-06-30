import 'dart:io';

void main(){
  stdout.write("Day: ");
  int day = int.parse(stdin.readLineSync()??'');
  stdout.write("Month: ");
  int month = int.parse(stdin.readLineSync()??'');
  List<int> list = [31,28,31,30,31,30,31,31,30,31,30,31];

  if(month>12) {
    print("Bunday oy yo'q");
    return;
  }

  if(list[month-1]<day) {
    print("Bunday sana yo'q");
    return;
  }

  day++;
  if(list[month-1]<day) {
    day = 1;
    month++;
    if(month>12) month=1;
  }

  print("${day.toString().padLeft(2,'0')}.${month.toString().padLeft(2,"0")}");

}