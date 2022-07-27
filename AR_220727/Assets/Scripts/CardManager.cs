using UnityEngine;

namespace Comibast.AR.Vuforia
{
    
        /// <summary>
        /// �Ϥ����Ѻ޲z��
        /// </summary>

        public class CardManager : MonoBehaviour
        {
            [SerializeField, Header("KID �Ϥ�")]
            private DefaultObserverEventHandler observerKID;

        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);
            observerKID.OnTargetLost.AddListener(CardLost);
        }

        /// <summary>
        /// �Ϥ����Ѧ��\
        /// </summary>
        private void CardFound()
        {
            print("<color=yellow>���d��</color>");
        }

        /// <summary>
        /// �Ϥ����ѥ���
        /// </summary>
        private void CardLost()
        {
            print("<color=red>�d�����ѥ���</color>");
        }
    }


}
