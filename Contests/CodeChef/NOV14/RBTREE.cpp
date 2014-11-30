#include <iostream>
#include <cstdio>
#include <cmath>
#include <cstring>
using namespace std;
 
int main() {
	int t,x,y,l1,l2;
	scanf("%d",&t);
	bool rib=true;
	char arr[3];
	int d,addn;
	while(t--){
		int red=0,black=0;
		bool cb;
		cin>>arr;
		//cout<<arr;
		if(!strcmp(arr,"Qi"))
		rib=!rib;
		else {
			scanf("%d %d",&x,&y);
			if(x<y)
			x^=y^=x^=y;//
			l1=log2(x);
			l2=log2(y);//cout<<l1<<l2;
			red = (l1-l2)/2;
			black = (l1-l2)-red;
			if(l1%2)
			black^=red^=black^=red;
			d=l1-l2;
			while(d--)
			x/=2;
			bool cb=true;
			if((int)log2(x)%2)
			cb=false;
			while(x!=y){
				if(cb)
				black+=2;
				else
				red+=2;
				x/=2;
				y/=2;
				cb=!cb;
			}
			if(cb)
			black++;
			else
			red++;
			/*
			addn = log2(x-y)+1;
			red+=(addn/2);
			black+=(addn/2);
			if(l2%2)
			red++;
			else
			black++;
			*/
			if(!rib)
			black^=red^=black^=red;
			if(!strcmp(arr,"Qr"))
			printf("%d\n",red);
			else
			printf("%d\n",black);
		}
		
	}
	return 0;
} 