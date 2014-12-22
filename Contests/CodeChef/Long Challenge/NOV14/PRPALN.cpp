#include <iostream>
#include <cstring>
using namespace std;
char arr[100010];
bool isPalin(int a,int b){
	while(a<=b){
		if(arr[a]!=arr[b])
		return false;
		a++,b--;
	}
	return true;
}
int main() {
	
	int t,len,i,j,diff;
	bool val;
	scanf("%d",&t);
	while(t--){
		scanf("%s",&arr);
		len=strlen(arr);
		i=0;
		j=len-1;
		val=true;
		diff=0;
		//for(;i<j;){
			while(i<=j && arr[i]==arr[j])
			i++,j--;
			val = isPalin(i+1,j) || isPalin(i,j-1);
			//else if(i<j && arr[i+1]==arr[j])
			//i+=2,j++,diff++;
			//else if(i<j)
			//{diff=2;break;}
		//}
		if(!val)
		printf("NO\n");
		else
		printf("YES\n");
	}
	return 0;
}  