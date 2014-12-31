#include <bits/stdc++.h>
using namespace std;
#define lld long long int
#define MAX 1000001
bool isPrime[1000002];
int primes[200010];
int mappedInt[200010];
int prLen=0;

void setVals(int n){
    int i=2*n;
    while(i<MAX)
    {
        isPrime[i]=false;
        i+=n;
    }
}
void seive(){
    for(int i=0;i<MAX;isPrime[i++]=true);
    for(int i=2;i<MAX;i++)
    {
        while(i<MAX && isPrime[i]==false)i++;
        setVals(i);
    }
}
inline void setNull() {
    for(int i=0;i<100000;mappedInt[i++]=0);
}
void getPrimes()
{
    for(int i=2;i<MAX;i++)
        if(isPrime[i]==true)
        {
            primes[prLen++]=i;
        }
}
void incVal(int n)
{
    int cnt=0;
    for(int i=0;primes[i]<=n;i++)
    {
        cnt=0;
        while(n!=1 && n%primes[i]==0)
        {
            n/=primes[i];
            cnt++;
        }
        mappedInt[i]+=cnt;
    }
}
lld calcProd(int n)
{
    lld prod=1;
    for(int i=0;primes[i]<=n && i<prLen;i++)
    {
        while(mappedInt[i]==0 && primes[i]<=n && i<prLen) i++;
        prod*=(mappedInt[i]+1);
    }
    return prod;
}
int main() {
	seive();
	getPrimes();
	int t,n,tem,mv;
	scanf("%d",&t);
	while(t--)
	{
	    mv=-1;
		setNull();
		scanf("%d",&n);
		while(n--)
        {
            scanf("%d",&tem);
            mv=mv>tem?mv:tem;
            incVal(tem);
		}
		printf("%lld\n",calcProd(mv));
	}
	return 0;
}
