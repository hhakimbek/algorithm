import 'dart:io';

void main(){
  double x,y;
  stdout.write("x: ");
  x = double.parse(stdin.readLineSync()??'');
  stdout.write("y: ");
  y = double.parse(stdin.readLineSync()??'');
  if(x==y) {
    print("$x : $y");
    return;
  }

  double half = (x+y)/2;
  double doubled = x*y*2;

  if(x>y) {
    [x,y]=[doubled,half];
  } else {
    [x,y]=[half,doubled];
  }
  print("$x : $y");
  

}