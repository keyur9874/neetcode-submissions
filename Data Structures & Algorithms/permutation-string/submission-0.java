class Solution {
    public boolean checkInclusion(String s1, String s2) {
        if(s2.length() < s1.length())
            return false;

        int n = s1.length();
        int[] cnt = new int[26];
        for(int i=0; i<n; i++){
            cnt[s1.charAt(i)-'a']++;
        }

        int matches = 0;
        for(int i=0; i<26; i++){
            if(cnt[i]==0)
                matches++;
        }
        for(int i=0; i<s2.length(); i++){
            int in = s2.charAt(i)-'a';

            cnt[in]--;

            if(cnt[in]==0)
                matches++;
            
            if(i>=n){
                int out = s2.charAt(i-n)-'a';
                if(cnt[out]==0)
                    matches--;
                cnt[out]++;                
            }

            if(matches == 26)
                return true;
        }

        return false;
    }
}
