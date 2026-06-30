import 'dart:io';
import 'dart:math';

void main(){
  stdout.write("N = ");
  int n = int.parse(stdin.readLineSync()??'');
  for(int i=1;i<=n;i++) {
    int perfect = toPerfect(i);
    if(perfect>n) return;
    if(perfect!=0) print(perfect);
  }
}

int toPerfect(int p) {
  if(!isPrime(p)) return 0;
  int right = (pow(2, p)-1).toInt();
  if(!isPrime(right)) return 0;
  int result = (pow(2, p-1)*right).toInt();
  return result;
}

bool isPrime(int n) {
  if(n==2) return true;
  if(n%2==0 || n<2) return false;
  for(int i=3;i*i<=n;i+=2) {
    if(n%i==0) return false;
  }
  return true;
}