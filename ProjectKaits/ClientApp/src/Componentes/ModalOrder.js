import { useState, useEffect } from "react"
import { Button, Modal, ModalHeader, ModalBody, ModalFooter, Form, FormGroup, Label, Input } from "reactstrap"
import ModalClient from "./ModalClient"
import ModalProduct from "./ModalProduct"

const orderModel = {
    dateOrder: "",
    totalPrice: "",
    clientId: ""
}

const ModalOrder = ({ mostrarModal, setMostrarModal,saveOrder}) => {

    const [order, setOrder] = useState(orderModel);
    const [client, setClient] = useState([])
    const [product, setProduct] = useState([])
    const [mostrarModalClient, setMostrarModalClient] = useState(false);
    const [mostrarModalProduct, setMostrarModalProduct] = useState(false);

    const mostrarClient= async () => {

        const response = await fetch("api/clients/Get");

        if (response.ok) {
            const dataClient = await response.json();
            setClient(dataClient);
        } else {
            console.log("error al listar");
        }
    }

    const mostrarProduct = async () => {

        const response = await fetch("api/produts/Get");

        if (response.ok) {
            const dataProduct = await response.json();
            setProduct(dataProduct);
        } else {
            console.log("error al listar");
        }
    }

    useEffect(() => {
        mostrarClient()
        mostrarProduct()
    });

    const updateDate = (e) => {
        //console.log(e.target.name + " : " + e.target.value)
        setOrder(
            {
                ...order,
                [e.target.name] : e.target.value
            }
        )
    }

    const sendData = () => {
        saveOrder(order)
    }

    return (

        <Modal isOpen={mostrarModal}>
            <ModalHeader>
                Nuevo Pedido
            </ModalHeader>
            <ModalBody>
                <Form>
                    <FormGroup>
                        <Label> Fecha: </Label>
                        <Input name="dateOrder" onChange={(e) => updateDate(e)} value={order.dateOrder}/>
                    </FormGroup>
                    <FormGroup>
                        <Label> Cliente: </Label>
                        <Button color="primary" size="sm" onClick={setMostrarModalClient}>Agregar Cliente</Button>
                        <Input name="clientId" onChange={(e) => updateDate(e)} value={order.clientId} />
                    </FormGroup>
                    <FormGroup>
                        <Label> Agregar Productos: </Label>
                        <Button color="primary" size="sm" onClick={setMostrarModalProduct}>Agregar Productos</Button>
                    </FormGroup>
                    <FormGroup>
                        <Label> Total: </Label>
                        <Input name="totalPrice" onChange={(e) => updateDate(e)} value={order.totalPrice} />
                    </FormGroup>
                </Form>
            </ModalBody>
            <ModalClient dataClient={client} mostrarModalClient={mostrarModalClient} setMostrarModalClient={setMostrarModalClient} />
            <ModalProduct dataProduct={product} mostrarModalProduct={mostrarModalProduct} setMostrarModalProduct={setMostrarModalProduct} />

            <ModalFooter>
                <Button color="primary" size="sm" onClick={sendData}>Guardar</Button>
                <Button color="danger" size="sm" onClick={() => setMostrarModal(!mostrarModal) }>Cerrar</Button>
            </ModalFooter>
        </Modal>
    )
}

export default ModalOrder