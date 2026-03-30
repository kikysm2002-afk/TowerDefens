using UnityEngine;

public class Node : MonoBehaviour
{
    public GameObject tower; // 이 자리에 설치된 타워 저장

    void OnMouseDown() // 마우스로 이 노드를 클릭했을 때 실행
    {
        // 이미 타워가 있거나 돈이 부족하면 설치 안 함
        if (tower != null || PlayerStats.Money < 50) 
        {
            return;
        }

        // 돈 차감 (타워 가격 50원 가정)
        PlayerStats.Money -= 50;

      // Node.cs의 설치 로직 부분
GameObject towerToBuild = BuildManager.instance.towerPrefab; // .instance를 소문자로 확인!
tower = Instantiate(towerToBuild, transform.position, Quaternion.identity);
    }
}
