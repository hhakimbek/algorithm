#include <iostream>
using namespace std;

int main() {
    float x,y;
    cout<<"x: ";
    cin>>x;
    cout<<"y: ";
    cin>>y;
    if(x==y) {
        cout<<x<<" : "<<y;
        return 0;
    }

    float half = (x+y)/2;
    float doubled = x*y*2;

    float tempX = x;
    x = x<y?half:doubled;
    y = y<tempX?half:doubled; 


    cout<<x<<" : "<<y;
    

    return 0;
}
