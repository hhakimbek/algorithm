#include <iostream>
using namespace std;

int main() {
    cout<<"KABISA YILI"<<endl;
    int year;
    cout<<"Yil: ";
    cin>>year;
    if(year%400==0) {
        cout<<366;
    } else {
        if(year%4==0 && year%100!=0) {
            cout<<366;
        } else {
            cout<<365;
        }
    }
    return 0;
}
