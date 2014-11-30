#include <bits/stdc++.h>
using namespace std;
int F(char *s,int n)
{
	int bal=0;
	int maxb=0;
	
	for(int i=0;i<n;i++)
	{
		if(s[i]=='(')
		bal++;
		else
		bal--;
		maxb=maxb>bal?maxb:bal;
	}
	return maxb;
}
int main() {
	int t;
	scanf("%d",&t);
	int len;
	char s[100010];
	while(t--)
	{
		scanf("%s",&s);
		len=strlen(s);
		int res=F(s,len);
		for(int i=0;i<res;i++)
		printf("(");
		for(int i=0;i<res;i++)
		printf(")");
		printf("\n");
	}
	return 0;
}