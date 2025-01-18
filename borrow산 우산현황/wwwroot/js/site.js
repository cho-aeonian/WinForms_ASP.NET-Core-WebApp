function goToPage(boxNumber) {
    // URL을 /return-screen 경로로 설정하고 boxNumber를 쿼리 매개변수로 전달
    const targetPage = '/return-screen?box=' + boxNumber;
    window.location.href = targetPage; // 페이지 이동
}
