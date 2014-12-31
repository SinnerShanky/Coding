#include <iostream>
#include <algorithm>
#include <map>
using namespace std;

int main() {
	int t,n,k;
	scanf("%d",&t);
	while(t--){
		map<int,int> m;
		scanf("%d %d",&n,&k);
		int arr[n];
		for(int i=0;i<n;scanf("%d",&arr[i++]));
		sort(arr,arr+n);
		int count=0,min=arr[0]+arr[n-1]+k;
		for(int i=0;i<n-1;i++) {
			for(int j=i+1;j<n;j++) {
				int val = abs(arr[i]+arr[j]-k);
				if(val<min){
					min = val;
					count=1;
				}
				else if(val==min)
				count++;
			}
		}
		printf("%d %d\n",min,count);
	}
	return 0;
}
