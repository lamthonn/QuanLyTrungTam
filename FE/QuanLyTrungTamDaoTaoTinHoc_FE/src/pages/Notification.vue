<template>
  <div style="display:flex;">
    <div style="width: 15%">
      <a-button type="primary" style="margin-bottom: 16px" @click="toggleCollapsed">
        <MenuUnfoldOutlined v-if="state.collapsed" />
        <MenuFoldOutlined v-else />
      </a-button>
      <a-menu v-model:openKeys="state.openKeys" v-model:selectedKeys="state.selectedKeys" mode="inline" theme="light"
        :inline-collapsed="state.collapsed" :items="items" @click="hanldeClick"></a-menu>
    </div>
    <div style="width: 75%; ">
      <!-- <PlusSquareOutlined style="font-size:25px;" v-if="roleData === '1' || role === '1'">Thêm thông báo</PlusSquareOutlined> -->
      <div v-if="role === '1' || roleData === '1'" style="display: flex; justify-content: flex-end;">
          <a-dropdown-button >
              Khác
              <template #overlay>
                  <a-menu>
                      <a-menu-item @click="showModal" key="1">Thêm thông báo</a-menu-item>
                  </a-menu>
              </template>
          </a-dropdown-button>
      </div>
      <a-tabs>
        <a-tab-pane key="1" tab="Học Viên">
          <a-collapse v-model:activeKey="activeKey1">
            <a-collapse-panel v-for="(hv, index) in dataHocVien" :key="index" :header="hv.title">
              <div style="display:flex;">
                <p>{{ hv.description }}</p>
                <div class="roleAdmin" style="display: grid;" v-if="roleData === '1' || role === '1'">
                  <div>
                    <a-button type="primary" @click="showModalEdit">Sửa</a-button>
                    <a-modal v-model:open="openEdit" title="Sửa Thông Báo" @ok="EditData(hv.id)">
                      <a-textarea v-model:value="EditThongBao" placeholder="Chi Tiết" :rows="4" />
                    </a-modal>
                  </div>
                  <div>
                    <a-button type="primary" @click="btnDelete(hv.id)">Xóa</a-button>
                  </div>
                </div>
              </div>
            </a-collapse-panel>
          </a-collapse>
        </a-tab-pane>

        <a-tab-pane key="2" tab="Giảng Viên">
          <a-collapse v-model:activeKey="activeKey2">
            <a-collapse-panel v-for="(gv, index) in dataGiangVien" :key="index" :header="gv.title">
              <p>{{ gv.description }}</p>
              <div class="roleAdmin" style="display: grid;" v-if="roleData === '1' || role === '1'">
                  <div>
                    <a-button type="primary" @click="showModalEdit">Sửa</a-button>
                    <a-modal v-model:open="openEdit" title="Sửa Thông Báo" @ok="EditData(gv.id)">
                      <a-textarea v-model:value="EditThongBao" placeholder="Chi Tiết" :rows="4" />
                    </a-modal>
                  </div>
                  <div>
                    <a-button type="primary" @click="btnDelete(gv.id)">Xóa</a-button>
                  </div>
                </div>
            </a-collapse-panel>
          </a-collapse>
        </a-tab-pane>
      </a-tabs>
    </div>
  </div>
  <AddNotice ref="xemRef"/>
</template>

<script>
import {
  Tabs,
  TabPane,
  Collapse,
  CollapsePanel,
  Modal,
  Button,
  Textarea,
  Menu,
  DropdownButton,
  MenuItem
} from 'ant-design-vue/es/components'
import {
  MenuFoldOutlined,
  MenuUnfoldOutlined,
  TeamOutlined,
  MailOutlined,
  PlusSquareOutlined 
} from '@ant-design/icons-vue';
import { computed, h, reactive, ref } from 'vue';
import axios from 'axios';
import { useStore } from 'vuex';
import { notification } from 'ant-design-vue';
import { useRouter } from 'vue-router';
import AddNotice from '../components/Notification/AddNotice.vue'
export default {
  name: 'Notification',
  components: {
    ATabs: Tabs,
    ATabPane: TabPane,
    ACollapse: Collapse,
    ACollapsePanel: CollapsePanel,
    AModal: Modal,
    AButton: Button,
    ATextarea: Textarea,
    AMenu: Menu,
    ADropdownButton:DropdownButton,
    AMenuItem:MenuItem,

    MenuFoldOutlined,
    MenuUnfoldOutlined,
    TeamOutlined,
    MailOutlined,
    PlusSquareOutlined,
    AddNotice
  },
  setup() {
    const router = useRouter();
    const Role = ref(localStorage.getItem("ROLE"));
    const RoleData = computed(() => store.state.Role);
    const state = reactive({
            collapsed: false,
            selectedKeys: ['3'],
            // openKeys: ['sub1'],
            // preOpenKeys: ['sub1'],
        });
    const items = reactive([
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
    //thông báo
    const store = useStore();
    const activeKey1 = ref([]);
    const activeKey2 = ref([]);
    const dataHocVien = ref([]);
    const dataGiangVien = ref([]);
    //Role
    const role = computed(() => localStorage.getItem("ROLE"));
    const roleData = computed(() => store.state.Role);

    //EditThongBao
    const EditThongBao = ref('');
    const EditData = (id) => {
      axios.put(`https://localhost:7255/api/ThongBao/${id}`,{
        id:id,
        description:EditThongBao.value,
      })
      .then(()=>{
        notification.open({
              message: 'Sửa thông báo thành công',
              onClick: () => {
                console.log('Notification Clicked!');
              },
            });
      openEdit.value = false;
      })
    }

    //modal add
    const xemRef = ref();
    const showModal =() => {
            xemRef.value.visible = true
        }
    const openEdit = ref(false);

    const showModalEdit = () => {
      openEdit.value = true;
    };

    const btnDelete = async (id) => {
      await axios.delete(`https://localhost:7255/api/ThongBao/${id}`)
      .then(()=>{
        if(confirm("bạn có chắc chắn muốn xóa thông báo này?")){
          notification.open({
              message: 'Xóa thông báo thành công',
              onClick: () => {
                console.log('Notification Clicked!');
              },
            });
        }
      })
      .catch(err=>{
        notification.open({
              message: `${err}`,
              onClick: () => {
                console.log('Notification Clicked!');
              },
            });
      })
    }

    return {
      router,
      store,
      activeKey1,
      activeKey2,
      dataHocVien,
      dataGiangVien,
      state,
      items,

      role,
      roleData,

      openEdit,
      EditThongBao,
      xemRef,

      showModalEdit,
      showModal,
      EditData,
      btnDelete,
      toggleCollapsed,
      hanldeClick,
    }
  },
  mounted() {
    //lấy thông báo cho học viên
    const HVGetDataNotification = () => {
      axios.post('https://localhost:7255/api/ThongBao/GetThongBao', {
        'doiTuong': 'Học Viên'
      })
        .then(res => {
          this.dataHocVien = res.data
          console.log(res.data);
        })
        .catch(err => console.log(err))
    }
    HVGetDataNotification();

    //lấy thông báo cho giảng viên
    const GVGetDataNotification = () => {
      axios.post('https://localhost:7255/api/ThongBao/GetThongBao', {
        'doiTuong': 'Giảng Viên'
      })
        .then(res => this.dataGiangVien = res.data)
        .catch(err => console.log(err))
    }
    GVGetDataNotification();
  },
}
</script>

<style></style>