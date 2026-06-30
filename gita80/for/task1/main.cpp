#include <iostream>
#include <cmath>
using namespace std;

// long long => 2^63 - 1
bool isPrime(int n);
long long int toPerfect(int p);

int main() {
    cout<<"N: ";
    int n;
    cin>>n;
    for(int i=1;i<=n;i++) {
        long int perfect = toPerfect(i);
        // if(perfect>n) return 0;
        if(perfect!=0)cout<<perfect<<endl;
    }
    return 0;
}

long long toPerfect(int p) {
    //Using Euclid's formula: 2^(p-1)*(2^p - 1)
    if(!isPrime(p)) return 0;
    long long right = pow(2,p)-1;
    
    if(!isPrime(right)) return 0;
    
    long long result = pow(2,p-1)*right;
    return result;
}

bool isPrime(int n) {
    if(n==2) return true;
    if(n%2==0 || n<2) return false;
    for(int i = 3;i*i<=n;i+=2) {
        if(n%i==0) return false;
    }
    return true;
}