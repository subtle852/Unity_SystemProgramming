using TMPro;
using UnityEngine;

public class GoodsUI : MonoBehaviour
{
    public TextMeshProUGUI GoldAmountTxt;
    public TextMeshProUGUI GemAmountTxt;

    public void SetValues()
    {
        var userGoodData = UserDataManager.Instance.GetUserData<UserGoodsData>();
        if (userGoodData == null)
        {
            Logger.LogError("No user goods data.");
            return;
        }

        GoldAmountTxt.text = userGoodData.Gold.ToString("N0");
        GemAmountTxt.text = userGoodData.Gem.ToString("N0");
    }
}
