<template >
    <div style=" width:90%; margin:20px 5%">
        <a-card style="width: 100%; background-color: rgb(233, 233, 233);">
            <div class="cardHeader">
                <a-card class="cardHeader-content">
                    <a-card-grid style="width: 50%; text-align: left" class="cardLeft">
                        <h4><i class="fa-solid fa-user"></i> Tài Khoản: {{ username }}</h4>
                        <h6><i class="fa-solid fa-envelope"></i> Email: {{ email }}</h6>
                        <h6><i class="fa-solid fa-phone"></i> Điện Thoại: {{ phone }}</h6>
                        <h6><i class="fa-solid fa-home"></i> Địa Chỉ: {{ address }}</h6>
                    </a-card-grid>
                    <a-card-grid style="width: 50%; text-align: center" class="cardRight">
                        <img src="../assets/information/logo_pts.png" style="width: 50%;" alt="" />
                        <h3 style="font-align:center; margin-top:10px; color:white;">Cài đặt tài khoản</h3>
                    </a-card-grid>

                </a-card>
            </div>

            <div class="cardBody">
                <a-card class="cardBody-content">
                    <a-card-grid style="width: 100%;" class="content-grid">
                        <div class="contentGrid-left">
                            <p style="margin:0; font-size:20px;">{{ role === '1' ? "Học viên: " : "Giảng viên: " }}</p>
                            <h3>{{ username }}</h3>
                        </div>
                        <div style="margin:0;" class="contentGrid-right">
                            <!-- <a-button type="primary" :size="size">
                            <template #icon>
                                <GlobalOutlined />
                            </template>
                            Trang xã hội
                        </a-button> -->
                            <a-button type="primary" @click="showModalInformation">Sửa thông tin cá nhân</a-button>
                            <a-modal v-model:open="openInformation" @ok="handleOk">
                                <h5 class="titleUpdate">Chỉnh sửa thông tin cá nhân</h5>
                                <a-input v-model:value="formState.hotentxt" placeholder="Chỉnh sửa họ tên" />
                                <a-input style="margin-top:5px;" v-model:value="formState.phonetxt"
                                    placeholder="Chỉnh sửa số điện thoại" />
                                <a-input style="margin-top:5px;" v-model:value="formState.emailtxt"
                                    placeholder="Chỉnh sửa Email" />
                                <a-input style="margin-top:5px;" v-model:value="formState.address_txt"
                                    placeholder="Chỉnh sửa địa chỉ" />
                                <a-input style="margin-top:5px;" v-model:value="formState.datetxt"
                                    placeholder="Chỉnh sửa ngày sinh" />
                                <a-input style="margin-top:5px;" v-model:value="formState.sextxt"
                                    placeholder="Chỉnh sửa giới tính" />
                            </a-modal>
                        </div>
                    </a-card-grid>

                    <!-- Họ và tên -->
                    <a-card-grid style="width: 100%;" class="content-grid">
                        <div class="contentGrid-left" style="display:flex; align-items: center;">
                            <div class="icon">
                                <UserOutlined style="margin-right:10px; font-size:20px;" />
                            </div>
                            <div>
                                <p style="margin:0;">Họ và tên:</p>
                                <p style="color:rgb(13, 194, 134); font-size:20px; margin:0;">{{ name }}</p>
                            </div>
                        </div>

                    </a-card-grid>

                    <!-- Email -->
                    <a-card-grid style="width: 100%;" class="content-grid">
                        <div class="contentGrid-left" style="display:flex; align-items: center;">
                            <div class="icon">
                                <MailOutlined style="margin-right:10px; font-size:20px;" />
                            </div>
                            <div>
                                <p style="margin:0;">Email:</p>
                                <p style="color:rgb(13, 194, 134); font-size:20px; margin:0;">{{ email ? email : "--trống--"
                                }}</p>
                            </div>
                        </div>
                    </a-card-grid>

                    <!-- địa chỉ -->
                    <a-card-grid style="width: 100%;" class="content-grid">
                        <div class="contentGrid-left" style="display:flex; align-items: center;">
                            <div class="icon">
                                <HomeOutlined style="margin-right:10px; font-size:20px;" />
                            </div>
                            <div>
                                <p style="margin:0;">Địa chỉ:</p>
                                <p style="color:rgb(13, 194, 134); font-size:20px; margin:0;">{{ address ? address :
                                    "--trống--" }}</p>
                            </div>
                        </div>
                    </a-card-grid>

                    <!-- ngày sinh -->
                    <a-card-grid style="width: 100%;" class="content-grid">
                        <div class="contentGrid-left" style="display:flex; align-items: center;">
                            <div class="icon">
                                <CalendarOutlined style="margin-right:10px; font-size:20px;" />
                            </div>
                            <div>
                                <p style="margin:0;">Ngày sinh:</p>
                                <p style="color:rgb(13, 194, 134); font-size:20px; margin:0;">{{ date ? date : "--trống--"
                                }}
                                </p>
                            </div>
                        </div>
                    </a-card-grid>

                    <!-- giới tính -->
                    <a-card-grid style="width: 100%;" class="content-grid">
                        <div class="contentGrid-left" style="display:flex; align-items: center;">
                            <div class="icon">
                                <MehOutlined style="margin-right:10px; font-size:20px;" />
                            </div>
                            <div>
                                <p style="margin:0;">Giới tính:</p>
                                <p style="color:rgb(13, 194, 134); font-size:20px; margin:0;">{{ sex ? sex : "--trống--" }}
                                </p>
                            </div>
                        </div>
                    </a-card-grid>
                </a-card>
            </div>
        </a-card>
    </div>
</template>

<script>
import {
    Card,
    CardGrid,
    Button,
    Modal,
    Input,
    notification
} from 'ant-design-vue/es/components'
import {
    GlobalOutlined,
    UserOutlined,
    MailOutlined,
    HomeOutlined,
    CalendarOutlined,
    MehOutlined,
} from '@ant-design/icons-vue';
import { computed, reactive, ref } from 'vue';
import { useStore } from 'vuex';
import axios from 'axios';
export default {
    name: 'Information',
    components: {
        ACard: Card,
        ACardGrid: CardGrid,
        AButton: Button,
        AModal: Modal,
        AInput: Input,

        GlobalOutlined,
        UserOutlined,
        MailOutlined,
        HomeOutlined,
        CalendarOutlined,
        MehOutlined,
    },
    setup() {
        const store = useStore()

        const role = computed(() => localStorage.getItem("ROLE"));
        const username = computed(() => localStorage.getItem("USERNAME"));
        const email = ref('')
        const name = ref('');
        const phone = ref('');
        const address = ref('');
        const date = ref('');
        const sex = ref('');

        //thông tin người dùng sửa
        const formState = reactive({
            hotentxt: name ? name : '',
            emailtxt: email ? email : '',
            phonetxt: phone ? phone : '',
            address_txt: address ? address : '',
            datetxt: date ? date : '',
            sextxt: sex ? sex : '',
        })

        //modal
        const openInformation = ref(false);
        const showModalInformation = () => {
            openInformation.value = true;
        };

        //Update
        const handleOk = () => {
            axios.put(`https://localhost:7255/api/HocVien/Update/${username.value}`, {
                "maHV": username.value,
                "tenHV": formState.hotentxt,
                "diaChi": formState.address_txt,
                "sdt": formState.phonetxt,
                "email": formState.emailtxt,
                "ngaySinh": formState.datetxt,
                "gioiTinh": formState.address_txt
            })
                .then(() => {
                    notification.open({
                        message: 'sửa thông tin thành công!',
                        onClick: () => {
                            console.log('Notification Clicked!');
                        },
                    });
                    openInformation.value = false;
                })
                .catch((err) => {
                    notification.open({
                        message: 'sửa thất bại!!',
                        onClick: () => {
                            console.log('Notification Clicked!');
                        },
                    });
                })

        }


        return {
            store,
            username,
            email,
            name,
            phone,
            address,
            date,
            sex,
            role,

            //modal
            openInformation,
            formState,

            showModalInformation,
            handleOk,
        }
    },

    mounted() {
        const getdataUser = async () => {
            if (this.role === '2') {
                await axios.post('https://localhost:7255/api/HocVien/GetHocVien', {
                    'username': this.username
                })
                    .then(res => {
                        this.name = res.data.tenHV;
                        this.email = res.data.email;
                        this.phone = res.data.sdt;
                        this.address = res.data.diaChi;
                        this.date = res.data.ngaySinh;
                        this.sex = res.data.gioiTinh;
                    })
                    .catch(err => console.log(err))
            }
            if (this.role === '3') {
                await axios.post('https://localhost:7255/api/HocVien/GetGiangVien', {
                    'username': this.username
                })
                    .then(res => {
                        this.name = res.data.tenGV;
                        this.phone = res.data.sdt;
                        this.email = res.data.email;
                        this.address = res.data.diaChi;
                        this.date = res.data.ngaySinh;
                        this.sex = res.data.gioiTinh;
                    })
                    .catch(err => console.log(err))
            }
        }
        getdataUser();
    }
}
</script>

<style scoped>
.cardHeader {
    width: 100%;
    padding: 10px 0;
}

.cardHeader-content {
    background-color: #5dc2a7;
    width: 50%;
    margin-left: 25%;
}

.cardLeft {
    border-right: 1px solid;
    color: white;

}

.cardBody {
    width: 100%;
    padding: 10px 0;
}

.cardBody-content {
    width: 60%;
    margin-left: 20%;
}

.content-grid {
    padding: 24px 80px;
    display: flex;
    border-bottom: 2px dotted;
}

.contentGrid-left {
    width: 50%;
}

.contentGrid-right {
    width: 50%;
    display: flex;
    justify-content: right;
    align-items: center;
}

.titleUpdate {
    text-align: center;
    text-transform: uppercase;
    font-size: 25px;
    font-weight: bold;
    color: #198754;
}
</style>
