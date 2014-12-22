#include<bits/stdc++.h>
using namespace std;
int main(){
    long long int t,n;
    scanf("%lld",&t);
    while(t--)
    {
        scanf("%lld",&n);
        if(n<=3) {printf("%d\n",n);continue;}
        if(n%2==0)
            printf("3\n");
        else
            printf("4\n");
    }
}
