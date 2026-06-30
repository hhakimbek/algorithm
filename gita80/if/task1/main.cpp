#include <iostream>
#include <cmath>
using namespace std;


int main() {
    int a,b,c;
    cout<<"a = ";
    cin>>a;
    cout<<"b = ";
    cin>>b;
    cout<<"c = ";
    cin>>c;
    int minimumV1 = a;
    if(minimumV1>b) minimumV1 = b;
    if(minimumV1>c) minimumV1 = c;
    cout<<"Min V1: "<<minimumV1<<endl;

    int minimumV2 = min(a,min(b,c));
    cout<<"Min V2: "<<minimumV2<<endl;

    return 0;
}
