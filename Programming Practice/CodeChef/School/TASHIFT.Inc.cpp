#include <bits/stdc++.h>
using namespace std;

int main()
{
    int len;
    char a[1000010],b[1000010];
    scanf("%d",&len);
    scanf("%s",&a);
    scanf("%s",&b);
    int lcp=0,lcpt=0,fi;
    int i=0,k=0;
    i=0;
    lcp=0;
    bool fl;
    while(i<len){
        fl=true;
        while(i<len && b[i]!=a[0]) i++;
        int j=1, tem=(i+1)%len;
        lcpt=1;
        for(;j<len && a[j]==b[tem];j++,lcpt++,tem=(tem+1)%len)
        {
            if(fl && b[tem]!=a[0]) k++;
            else fl=false;
        }
        if(lcpt>lcp) {
            lcp=lcpt;
            fi=i;
        }
        i+=k;
    }
    printf("%d\n",fi);
}
