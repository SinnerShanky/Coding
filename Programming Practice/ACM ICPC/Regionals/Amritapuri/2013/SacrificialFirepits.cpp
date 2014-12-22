#include<bits/stdc++.h>
using namespace std;
int main(){
    int t,a,b;
    scanf("%d",&t);
    while(t--)
    {
        scanf("%d %d",&a,&b);
        if(a<b) a^=b^=a^=b;
        float len=0;
        len=a/2.0;
        len+=max((float)b,len);
        len*=((sqrt(3)/2.0)*a);
        printf("%.3f\n",len);
    }
}
