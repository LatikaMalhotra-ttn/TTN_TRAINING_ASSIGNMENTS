import React,{Component} from 'react'
import Aux from '../Auxilary/Auxilary'
import Modal from '../../components/UI/Model/Model'



// const withErrorHandler=(WrappedComponent,axios)=>{
//     return class extends Component{
//         state={
//             error:null
//         }

//         componentDidMount(){
//             axios.interceptors.request.use(req=>{
//                 this.state({error:null});
//                 return req;
//             })
//             axios.interceptors.response.use(res=>res,error=>{
//                 this.state({error:error})
//             })
//         }

//         errorConfirmedhandler=()=>{
//             this.setState({error:null})
//         }

//         render(){
//             return(
//                 <Aux>
//                     <Model show={this.state.error} modalClosed={this.errorConfirmedhandler}>
//                         {this.state.error?this.state.error.message:null}
//                         {/* Something went wrong!! */}
//                     </Model>
//                     <WrappedComponent {...this.props}/>
//                 </Aux>
//             )
//         }
//     } 
// }


// export default withErrorHandler;





const withErrorHandler = ( WrappedComponent, axios ) => {
    return class extends Component {
        state = {
            error: null
        }

        //to add interseptors
        componentWillMount () {
            this.reqIntersepters=axios.interceptors.request.use(req => {
                this.setState({error: null});
                return req;
            });
            this.resIntersepters=axios.interceptors.response.use(res => res, error => {
                this.setState({error: error});
            });
        }

        //to remove interseptors to prevent memory leak
        componentWillUnmount(){
            axios.interceptors.request.eject(this.reqIntersepters);
            axios.interceptors.request.eject(this.resIntersepters);
        }

        errorConfirmedHandler = () => {
            this.setState({error: null});
        }

        render () {
            return (
                <Aux>
                    <Modal 
                        show={this.state.error}
                        modelClosed={this.errorConfirmedHandler}>
                        {this.state.error ? this.state.error.message : null}
                    </Modal>
                    <WrappedComponent {...this.props} />
                </Aux>
            );
        }
    }
}

export default withErrorHandler;