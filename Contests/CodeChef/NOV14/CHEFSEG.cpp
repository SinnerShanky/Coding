#include <iostream>
#include <cmath>
#include <cstdio>
using namespace std;
#define llu long long unsigned
 
int main() {
	int t;
	scanf("%d",&t);
	while(t--){
		llu x,k;
		scanf("%llu %llu",&x,&k);
		long double val = log2(k);
		long double fl = (int)val;
		long double ci = val-(int)val?(int)val+1:val+1;
		long double mul = k-(pow(2,fl))+1;
		mul = mul*2-1;
		long double nd = pow(2,ci);
		nd = x/nd;
		nd = nd*mul;
		printf("%Lf\n",nd);
	}
	return 0;
}