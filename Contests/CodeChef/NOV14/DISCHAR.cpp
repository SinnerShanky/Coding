#include <iostream>
#include <cstring>
using namespace std;
 
int main() {
	int t;
	scanf("%d",&t);
	char arr[100010];
	while(t--){
		cin>>arr;
		int len = strlen(arr);
		int freq[256];
		for(int i=0;i<256;freq[i++]=-1);
		int tem=0;
		for(int i=0;i<len;i++){
			if(freq[arr[i]]==-1)
				tem++;
			freq[arr[i]]=i;
		}
		printf("%d\n",tem);
	}
	return 0;
}