public class Result
{
    public static int UniqueWolfs(List<int> wolfList)
    {
        Dictionary<int, int> countMap = new Dictionary<int, int>();

        foreach (int wolf in wolfList)
        {
            if (countMap.ContainsKey(wolf))
                countMap[wolf]++;
            else
                countMap[wolf] = 1;
        }

        int maxCount = 0;
        int minID = int.MaxValue;

        foreach (KeyValuePair<int, int> pair in countMap)
        {
            int wolfID = pair.Key;
            int count = pair.Value;

            if (count > maxCount || (count == maxCount && wolfID < minID))
            {
                maxCount = count;
                minID = wolfID;
            }
        }

        return minID;
    }
}