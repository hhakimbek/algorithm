#include <iostream>
#include <iomanip>
using namespace std;

int main() {
    int month,day;
    cout<<"Day: ";
    cin>>day;
    cout<<"Month: ";
    cin>>month;
    
    int arr[12] = {31,28,31,30,31,30,31,31,30,31,30,31};

    if(!(month>0 && month<13)) {
        cout<<"Bunday oy yo'q";
        return 0;
    }

    
    if(arr[month-1]<day) {
        cout<<"Bunday sana yo'q";
        return 0;
    } 

    if(day<arr[month-1]) {
        day++;
    } else {
        day=1;
        month++;
        if(month>12) month=1;
    }
    
    cout<<setw(2)<<setfill('0')<<day<<"."<<setw(2)<<setfill('0')<<month;
    

    
    return 0;
}
