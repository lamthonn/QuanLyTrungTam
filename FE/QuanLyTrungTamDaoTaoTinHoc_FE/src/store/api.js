const localPath = "https://localhost:7255";
 const apiUrl = {
    //khóa học
    GET_ALL_KHOA_HOC:`${localPath}/api/KhoaHoc/getAllCourses`,
    DELETE_KHOA_HOC:`${localPath}/api/KhoaHoc`,

    //thanh toán
    CREATE_CHECKOUT_SESION:`${localPath}/api/Payment/create-checkout-session`,
    CHECK_PAYMENT:`${localPath}/api/KhoaHoc/Check-payment`
}

export default apiUrl;