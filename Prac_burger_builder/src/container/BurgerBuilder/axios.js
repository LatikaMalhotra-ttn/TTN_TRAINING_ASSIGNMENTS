import axios from "axios";


// setting the base url which would be useed to handle http request
const axiosInstance = axios.create({
    baseURL:"https://burgerbuilder-reactprac.firebaseio.com/"
});


export default axiosInstance;
