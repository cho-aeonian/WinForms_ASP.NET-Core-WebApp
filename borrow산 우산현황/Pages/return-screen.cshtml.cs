using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace borrow산_우산현황.Pages
{
    public class ReturnScreenModel : PageModel
    {
        // 반납 날짜를 표시할 속성
        public DateTime ReturnDate { get; set; }
            public void OnGet(int boxId)
        {
            // 박스 번호에 따라 다른 반납 정보를 처리할 수 있습니다.
            // 예: 우산 ID에 따라 다른 반납 날짜나 정보를 설정
            ReturnDate = DateTime.Now.AddDays(3);  // 예시로 3일 후 날짜
                                                   // 추가 로직을 여기에 작성할 수 있습니다.
        }
    }
}


