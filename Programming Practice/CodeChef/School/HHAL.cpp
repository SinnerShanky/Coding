#include <stdio.h>
#include <string.h>
int main()
{
	int t,len,i,j;
	bool palin = false;
	scanf("%d",&t);
	char str[100001];
	while(t--) {
		scanf("%s",&str);
		len = strlen(str);
		palin = true;
		i=0,j=len-1;
		while(i<j){
            if(str[i]!=str[j])
            {
                palin = false;
                break;
            }
            else i++,j--;
		}
		if(palin)
		printf("1\n");
		else
		printf("2\n");
	}
	return 0;
}
