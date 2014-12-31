#include <iostream>
#include <vector>
#include <algorithm>
#include <string>

using namespace std;

string s;
int n, sec, thi, fou, ans = 0;

int main(){
    cin >> s;
    n = s.size();
    sec = 0;
    thi = 0;
    fou = 0;
    /*Choose first unused C, then first unused H,
     that goes after choosen C, and so on.
    */
    for (int i = 0; i < n; ++i)
        if (s[i] == 'C') {
           sec = max(sec, i+1);
           while (sec < n && s[sec] != 'H') ++sec;
           if (sec == n) break;
           thi = max(thi, sec + 1);
           while (thi < n && s[thi] != 'E') ++thi;
           if (thi == n) break;
           fou = max(fou, thi + 1);
           while (fou < n && s[fou] != 'F') ++fou;
           if (fou == n) break;
           sec++; fou++; thi++;
           ans++;
        }
    printf("%d\n",ans);
}
