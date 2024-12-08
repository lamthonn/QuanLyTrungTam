<template>
    <div style="display:flex;">
        <div style="width: 15%">
            <a-button type="primary" style="margin-bottom: 16px" @click="toggleCollapsed">
                <MenuUnfoldOutlined v-if="state.collapsed" />
                <MenuFoldOutlined v-else />
            </a-button>
            <a-menu v-model:openKeys="state.openKeys" 
                    v-model:selectedKeys="state.selectedKeys" 
                    mode="inline" 
                    theme="light"
                    :inline-collapsed="state.collapsed" 
                    :items="items"
                    @click="hanldeClick"
            ></a-menu>
        </div>

        <div class="contentPost">
            <div>
                <a-card class="CardPost" 
                        :bordered="false" 
                        style="width: 600px; box-shadow:2px 2px 2px 2px;display:grid;"
                        v-for="post in posts"
                        :key="post.postId"
                        >
                    <div class="headerCard">
                        <div class="headerLeft">
                            <h5>Học Viên: {{ post.maHV }}</h5>
                            <p>{{ post.title }}</p>
                        </div>
                        <div class="headerRight">
                                <a-popover>
                                    <template #content>
                                    <p>Sửa bài viết</p>
                                    <p>Xóa bài viết</p>
                                    </template>
                                    <i class="fa-solid fa-ellipsis"></i>
                                </a-popover>
                        </div>
                    </div>
                    <div class="bodyCard">
                        <div class="bodyleft">
                            <a-image
                                width="95%"
                                :src="require(`../assets/media/${post.pathImage}`)"
                                style="border-radius:15px;"
                            />
                        </div>
                        <div class="bodyright">
                            <i class="fa-solid fa-heart" style="font-size:40px;cursor: pointer;"></i>
                            <i class="fa-regular fa-comment-dots" style="font-size:40px;cursor: pointer;"></i>
                        </div>
                    </div>
                </a-card>

            </div>
        </div>
    </div>
    <addNews ref="xemRef" />
</template>

<script>
import { Menu, Button, Card, Image, Popover, notification  } from 'ant-design-vue';
import {
    MenuFoldOutlined,
    MenuUnfoldOutlined,
    TeamOutlined,
    MailOutlined,
    PlusCircleOutlined
} from '@ant-design/icons-vue';
import { computed, h, reactive, ref } from 'vue';
import router from '@/router';
import addNews from '@/components/socialMedia/addNews.vue';
import axios from 'axios';
import { useStore } from 'vuex';
export default {
    name: 'socialMedia',
    components: {
        AMenu: Menu,
        AButton: Button,
        ACard:Card,
        AImage:Image,
        APopover:Popover,
        addNews,
        MenuFoldOutlined,
        MenuUnfoldOutlined,
        TeamOutlined,
        PlusCircleOutlined,
    },
    setup() {
        const store = useStore();
        const posts = ref([])
        const xemRef = ref();
        const state = reactive({
            collapsed: false,
            selectedKeys: ['2'],
            // openKeys: ['sub1'],
            // preOpenKeys: ['sub1'],
        });
        const visible = ref(false);
        const Role = ref(localStorage.getItem("ROLE"));
        const RoleData = computed(() => store.state.Role);
        const hide = () => {
        visible.value = false;
        };
        const items = reactive([
            {
                key: '1',
                icon: () => h(PlusCircleOutlined),
                label: 'Bài viết mới',
                title: 'Bài viết mới',
            },
            {
                key: '2',
                icon: () => h(TeamOutlined),
                label: 'Xã hội',
                title: 'Xã hội',
                
            },
            {
                key: '3',
                icon: () => h(MailOutlined),
                label: 'Thông báo',
                title: 'Thông báo',
                
            },
           
        ]);
        const openNotificationWithIcon = (type) => {
            notification[type]({
                message: 'Cảnh Báo',
                description:
                'Chỉ học viên mới có quyền đăng bài',
            });
        };
        const toggleCollapsed = () => {
            state.collapsed = !state.collapsed;
            // state.openKeys = state.collapsed ? [] : state.preOpenKeys;
        };
        const hanldeClick = (key) => {
            if(key.key === '1')
            {
                if(Role.value === '2' || RoleData.value === '2' )
                {
                    addBaiViet();
                }
                else{
                    openNotificationWithIcon('warning')
                }
            }
            else if(key.key === '2')
            {
                router.push("/socialMedia");
            }
            else if(key.key === '3')
            {
                router.push("/notification");
            }
        }
        const addBaiViet =() => {
            xemRef.value.visible = true
        }

        const getdataPost = async () => {
            const respone = await axios.get("https://localhost:7255/api/SocialMedia")
            posts.value = respone.data
        }
        
        return{
            xemRef,
            state,
            items,
            posts,
            visible,
            Role,
            RoleData,

            toggleCollapsed,
            hanldeClick,
            addBaiViet,
            getdataPost,
            hide,
            openNotificationWithIcon,
        }
    },
    mounted(){
        this.getdataPost();
    }
}
</script>

<style>
.contentPost{
    width: 70%;
    display: flex;
    justify-content: center;
    margin-bottom: 5px;
    align-items: center;
}
.headerCard{
    display: flex;
    justify-content: space-between;
}
.bodyCard{
    width: 100%;
    display: flex;
}
.bodyleft{
    width: 90%;
}
.bodyright{
    width: 10%;
    display: grid;
    justify-items: center;
    align-items: center;
    align-content: space-evenly;
}
.CardPost{
    margin-top:25px ;
}
.fa-ellipsis{
    font-size:30px;
    cursor: pointer;
    padding: 5px 8px;
    border-radius: 19px;
}
.fa-ellipsis:hover{
    background-color: rgb(225, 225, 225);
}
</style>