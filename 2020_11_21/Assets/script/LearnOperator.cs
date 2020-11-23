using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int A = 10, B = 3;
    private void Start()
    {
        print(A > B); 
        print(A < B); 
        print(A >= B);
        print(A <= B);
        print(A == B);
        print(A != B);


        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);

        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);

        print(!true);
        print(!false);
    }

}
